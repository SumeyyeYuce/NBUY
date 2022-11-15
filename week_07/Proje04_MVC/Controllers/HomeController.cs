using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje04_MVC.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        string ad="Sümeyye";
        ViewBag.KisiAd=ad;
        string dil="En";
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

   
}
