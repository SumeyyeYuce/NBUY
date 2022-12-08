using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShopAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

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


//app.MapControllerRoute(
//    name: "productdetails",
//    pattern: "{url?}",//burdaki url de _ProductPartial dan gelen url oluyor
//    defaults: new { controller = "Shop", action = "ProductDetails" }
//    );//shop/productSwtaisl/iphone-13-plus bu þeilde nir istek olunca 


//app.MapControllerRoute(//kategoryiey göre filtreleme yapýacaz
//    name:"products",
//    pattern:"{category?}",//null olabilir burdaki kategori osýrada týklanýlan kategori ismi
//    defaults: new {controller="Shop",action="ProductList"} 
//    );


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
  
app.Run();
