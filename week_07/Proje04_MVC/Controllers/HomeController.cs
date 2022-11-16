using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje04_MVC.Controllers;

public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public decimal Price { get; set; }
}
public class Category
{
    public int Id { get; set; } 
    public string Name { get; set; }
}
public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        string ad="Sümeyye";
        ViewBag.KisiAd=ad;
        string dil="Tr";
        string selamlama;
        if (dil=="Tr")
        {
            selamlama="Hoşgeldiniz";
        }
        else if (dil=="En")
        {
            selamlama="Welcome";
        }
        else{
            selamlama="";
        }
        ViewBag.Selam=selamlama;


        return View();
    }
    public IActionResult About()
    {
        ViewBag.Hata=false;
        ViewData["Not"]=75;

        List<string>adlar=new List<string>(){"Sema","Harun","Sefa","Tugçe"};
        ViewData["Adlar"]=adlar;

        List<string>bolumler=new List<string>(){"İK","Muhasebe","Satışlar","Egitim"};
        ViewBag.Bolumler=bolumler;
        return View();
    }

    public IActionResult GetProducts()
    {
        List<Product> products=new List<Product>()
        {
            new Product(){Id=1,Name="İphone 13",Price=24000},
            new Product(){Id=2,Name="İphone 14",Price=25000},
            new Product(){Id=3,Name="İphone 15",Price=26000},
            new Product(){Id=4,Name="İphone 16",Price=27000},
            new Product(){Id=5,Name="İphone 17",Price=28000}


        };
        // ViewBag.Products=products;

        //bu yapı model
        return View(products);
    }

    public IActionResult GetCategories()
    {
        List<Category> categories =new List<Category>()
        {
            new Category(){Id=1,Name="Telefon"},
            new Category(){Id=2,Name="Tablet"},
            new Category(){Id=3,Name="Bilgisayar"},

        };
        return View(categories);
    }

}
