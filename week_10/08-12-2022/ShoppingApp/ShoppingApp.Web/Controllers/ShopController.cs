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
        

        public async Task<IActionResult> ProductList(string categoryurl)
        {

          
                List<Product> products = await _productManager.GetProductsByCategoryAsync(categoryurl);
                List<ProductDto> productDtos = new List<ProductDto>();
                foreach (var product in products)//içinde ProductDto lar bulunan bir liste oluyor
                {
                    productDtos.Add(new ProductDto //bu liste indexView e gidicek
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        ImageUrl = product.ImageUrl,
                        Url=product.Url
                        
                    });
                }
                return View(productDtos);
            
        }
        public  async Task<IActionResult> ProductDetails(string producturl)//ProductDetails product url bilgisi burada geliyor
        {
            if (producturl==null) //productDetail null se
            {
                return NotFound();
            }
            var product = await _productManager.GetProductDetailsByUrlAsync(producturl);
            ProductDetailsDto productDetailsDto = new ProductDetailsDto//ProductDetailsDto tipinde yeni bir view var
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Url = product.Url,
                Description = product.Description,
                Categories = product
                    .ProductCategories
                    .Select(pc => pc.Category)//herbir productCategory için Categry'yi seç
                    .ToList()
            };
            return View(productDetailsDto);
        }
    }
}
