using BlogApp.Entities.Dtos;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
                  
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var result=await _categoryService.GetAll();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            return Redirect("/Admin");
        }
    }
}
