using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Business.Concrete;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Data.Concrete;
using YemekSitesi.Data.Concrete.EfCore.Contexts;
using YemekSitesi.Entity.Concrete.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlite("Data Source=YemekSitesi.db"));
builder.Services.AddDbContext<YemekSitesiContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6; 
    options.Password.RequireNonAlphanumeric = true;

    options.Lockout.MaxFailedAccessAttempts = 5; 
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";
    options.LogoutPath = "/account/logout";
    options.AccessDeniedPath = "/account/accessdenied";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        Name = ".YemekSitesi.Security.Cookie",
        SameSite = SameSiteMode.Strict
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IFoodService, FoodManager>();

//builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new SmtpEmailSender(
//"smtp.office365.com",587, true, "wissen_deneme_d@hotmail.com","12345wissen"
  //  ));




var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "foods",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Food", action = "FoodList" }

    );


app.MapControllerRoute(
    name: "fooddetails",
    pattern: "yemekler/{foodurl}",
    defaults: new { controller = "Food", action = "FoodDetails" }

    );
app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
