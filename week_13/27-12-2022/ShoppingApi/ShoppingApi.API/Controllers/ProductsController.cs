using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Business.Abstract;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //Projenizde Swagger varsa tüm action metotlarınızın HttpRequist türü yazılmalıdır(HttpGet,HttpPost vb.)

        [HttpGet]
        public async Task<IActionResult> GetProducts() 
        {
            var products = await _productService.GetAllAsync();//bütün üürnleri getiircek
            return Ok(products); //geriye productları döndür ve başarılı dieyrek Ok döndür
        }
    }
}
