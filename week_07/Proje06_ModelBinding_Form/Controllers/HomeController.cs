using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    
    }
    
    public IActionResult YasGrubu()
    {
        return View();
    }
    [HttpPost]
    public  IActionResult YasGrubu(int yas, string ad)
    {
        if (yas==0)
        {
            ViewBag.YasGrubu="Yaş bilgisini giriniz";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad},Reşit degilsiniz!";
        }
        else if (yas<40)
        {
            ViewBag.YasGrubu=$"{ad},Gençsiniz!";
        }
        else if (yas<60)
        {
            ViewBag.YasGrubu=$"{ad},Gençlere taş çıkarırsınız!";
        }
        else 
        {
            ViewBag.YasGrubu=$"{ad},Emekli ol!!";
        }
        return View();
    }

    
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        //burdaa veri tabanına kayıt işlemi yapılacak
        //şimdilik biz gelen verilerin testini yapabilmek için tekrar sayafay bastıralım
        // ViewBag.ResultHeader=$"{productName} adlı ürün eklendi";
        // ViewBag.ResultBody=$"Category:{productCategory}, Price:{productPrice}";     
        return View(product);
    }









    // public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }

   

  
}
