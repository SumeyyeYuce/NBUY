using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje05_MVC_EfCore_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_EfCore_CodeFirst.Controllers
{
   
    public class ProductController : Controller
    {
  
        public IActionResult Index()
        {
            MyDbContext context=new MyDbContext();
            List<Product> products= context
                .Products
                .Include(p=>p.Category)
                .ToList();
            return View(products);
        }

       
    }
}