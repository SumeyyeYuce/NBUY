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
        options.Password.RequireDigit= true;//�ifre i�inde mutlaka rakam bulunsun demi� olduk
        options.Password.RequireLowercase= true;//�ifre i�inde mutlaka k���k harf bulunsun
        options.Password.RequireUppercase= true;//�ifre i�inde mutlaka b�y�k harf olsun
        options.Password.RequiredLength= 6;//�ifre en az 6 karakter olsun
        options.Password.RequireNonAlphanumeric= true;//�ifre i�inde alphanumeric karakterler (.,/ @...gibi) bulunmas� zorunlu olsun

    #endregion
   
    #region LoginSettings
        options.Lockout.MaxFailedAccessAttempts= 5;//kullan�c� en fazla 5 kez �st �ste hata yaparsa hesab� kitlicem demek
        options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromMinutes(5);//5 dakika sonra kullan�c� tekrar deneyebilsin demi� oluyoruz


    #endregion

    #region UserSettings
        options.User.RequireUniqueEmail= true;//bensersiz email adresi ile kay�t olunabilir.Daha �nceki kay�tl� maille birdaha kay�t olunamaz

    #endregion

    #region SignInSetings
        options.SignIn.RequireConfirmedEmail = false;//true ise email onay� aktif
        options.SignIn.RequireConfirmedPhoneNumber= false;//true ise telefon numaras� onay� aktif (yani sms ile onaylama)

    #endregion

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//eger a��lbilmesi i�in login olman�n zoeunlu oldugu bir istekte bulunursa kullan�c�n� y�nlendirecgi� sayfada buras� olucak(account controllerda login action metodu)
    options.LogoutPath = "/account/logout";//kullan�c� ��k�� yapt�g�nda y�nlendirilecek sayfa
    options.AccessDeniedPath= "/account/accessdenied";//yetkisiz gir� s�ras�nda y�nleniricek sayfa
    options.SlidingExpiration = true;//cookie nin ya�am s�resi biz bi�ey demedi�imiz s�rece 20dakikad�r. buras� true olursa heryeni istekte buras� tekrar ba�lar(20 dakika dan ba�lar)
    options.ExpireTimeSpan= TimeSpan.FromMinutes(5);//ya�am s�resini ayarlar
    options.Cookie = new CookieBuilder
    {
        HttpOnly=true,//http format�nda �al��s�n diyoruz
        Name =".ShoppingApp.Security.Cookie",
        SameSite = SameSiteMode.Strict //sayfan�n benzerini yap�lmam� i�in 
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
