using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using BlogApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//blogapp.mvc için kullan demiþ olduk


#region  servisler notu
/*
 //bu uygulam baþlarken blogAppContext'im çalýþsýn diyoruz(new yerine böyle yaptýk)
builder.Services.AddDbContext<BlogAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IArticleService, ArticleManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
*/
#endregion

#region servisExtensionsÝleCagrýlýrsa
builder.Services.LoadMyServices();

#endregion


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage(); //bu hata oluþtugunu da bir sayfada güzel bir þekilde görünsün dicez.
    app.UseStatusCodePages();

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name:"Admin",
    areaName:"Admin",
     pattern: "/Admin/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
