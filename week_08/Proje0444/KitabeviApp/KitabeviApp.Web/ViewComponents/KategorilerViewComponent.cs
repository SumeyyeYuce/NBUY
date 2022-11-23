using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitabeviApp.Web.ViewComponents
{
    public class KategorilerViewComponent : ViewComponent
    {
        KitabeviContext context = new KitabeviContext();
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["id"] != null)
            {
                ViewBag.SeciliKategori = int.Parse(RouteData.Values["id"].ToString());
            }

            return View(context.Kategoriler.ToList());
        }
    }
}