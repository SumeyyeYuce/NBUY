using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productManager;
        public ShopController (IProductService productManager)
        {
            _productManager = productManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        

        public async Task<IActionResult> ProductList(string id)
        {

          
                List<Product> products = await _productManager.GetProductsByCategoryAsync(id);
                List<ProductDto> productDtos = new List<ProductDto>();
                foreach (var product in products)//içinde ProductDto lar bulunan bir liste oluyor
                {
                    productDtos.Add(new ProductDto //bu liste indexView e gidicek
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        ImageUrl = product.ImageUrl,
                        Url=product.Url,
                        DateAdded = product.DateAdded,
                    });
                }
                return View(productDtos);
            
        }
        public  IActionResult ProductDetails(string id)
        {
            return View();
        }
    }
}
