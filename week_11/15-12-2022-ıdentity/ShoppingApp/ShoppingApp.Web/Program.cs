using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("DataSource=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();//default cookie

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
        options.Password.RequireDigit= true;//þifre içinde mutlaka rakam bulunsun demiþ olduk
        options.Password.RequireLowercase= true;//þifre içinde mutlaka küçük harf bulunsun
        options.Password.RequireUppercase= true;//þifre içinde mutlaka büyük harf olsun
        options.Password.RequiredLength= 6;//þifre en az 6 karakter olsun
        options.Password.RequireNonAlphanumeric= true;//þifre içinde alphanumeric karakterler (.,/ @...gibi) bulunmasý zorunlu olsun

    #endregion
   
    #region LoginSettings
        options.Lockout.MaxFailedAccessAttempts= 5;//kullanýcý en fazla 5 kez üst üste hata yaparsa hesabý kitlicem demek
        options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);//5 dakika sonra kullanýcý tekrar deneyebilsin demiþ oluyoruz


    #endregion

    #region UserSettings
        options.User.RequireUniqueEmail= true;//bensersiz email adresi ile kayýt olunabilir.Daha önceki kayýtlý maille birdaha kayýt olunamaz

    #endregion

    #region SignInSetings
        options.SignIn.RequireConfirmedEmail = false;//true ise email onayý aktif
        options.SignIn.RequireConfirmedPhoneNumber= false;//true ise telefon numarasý onayý aktif (yani sms ile onaylama)

    #endregion

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//eger açýlbilmesi için login olmanýn zoeunlu oldugu bir istekte bulunursa kullanýcýný yönlendirecgið sayfada burasý olucak(account controllerda login action metodu)
    options.LogoutPath = "/account/logout";//kullanýcý çýkýþ yaptýgýnda yönlendirilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied";//yetkisiz girþ sýrasýnda yönleniricek sayfa
    options.SlidingExpiration = true;//cookie nin yaþam süresi biz biþey demediðimiz sürece 20dakikadýr. burasý true olursa heryeni istekte burasý tekrar baþlar(20 dakika dan baþlar)
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//yaþam süresini ayarlar
    options.Cookie = new CookieBuilder
    {
        HttpOnly=true,//http formatýnda çalýþsýn diyoruz
        Name =".ShoppingApp.Security.Cookie",
        SameSite = SameSiteMode.Strict //sayfanýn benzerini yapýlmamý için 
    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x => new 
 SmtpEmailSender(
    "smtp.office365.com",587,true,"wissen_core@hotmail.com","Wissen123."

    ));

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
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
