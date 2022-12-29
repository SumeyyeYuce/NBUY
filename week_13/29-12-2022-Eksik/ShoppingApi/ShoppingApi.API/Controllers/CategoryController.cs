using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.API.Model;
using ShoppingApi.Business.Abstract;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            var categories = await _categoryService.GetAllAsync();//bütün üürnleri getiircek
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            foreach (var category in categories)
            {
                categoryDtos.Add(new CategoryDto
                {

                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                   
                    Url = category.Url
                });
            }
            return Ok(categoryDtos); //geriye productları döndür ve başarılı dieyrek Ok döndür
        }
    }
}
