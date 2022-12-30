using YemekSitesi.Business.Abstract;
using YemekSitesi.Business.Concrete;
using YemekSitesi.Data.Abstract;
using YemekSitesi.Data.Concrete;
using YemekSitesi.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<YemekSitesiContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IFoodService, FoodManager>();    

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
  
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "foods",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Food", action = "FoodList" }

    );


app.MapControllerRoute(
    name: "fooddetails",
    pattern: "yemekler/{foodurl}",//produvt sla� ��rn url diye �al���r
    defaults: new { controller = "Food", action = "FoodDetails" }

    );
//app.MapAreaControllerRoute(
//    name: "Admin",
//    areaName: "Admin",//kla�rden bahsettik
//    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
