using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
        _productManager = productManager;
    }

    public async Task<IActionResult> Index()
    {
        List<Product> products = await _productManager.GetAllAsync();
        List<ProductDto> productsDto = new List<ProductDto>();  
        foreach (var product in products)
        {
            productsDto.Add(new ProductDto //yeni bir product listesi
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                DateAdded = DateTime.Now,
            });
        }
        return View(productsDto);
    }

    
}
