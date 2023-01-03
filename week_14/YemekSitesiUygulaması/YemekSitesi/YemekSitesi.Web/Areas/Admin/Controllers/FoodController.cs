using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Core;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Web.Areas.Admin.Models.Dtos;

namespace YemekSitesi.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;

        public FoodController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var food = await _foodService.GetFoodsWithCategories();
            var foodListDto = food
                .Select(f => new FoodListDto
                {
                    Food=f
                }).ToList();
            return View(foodListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            var foodAddDto = new FoodAddDto
            {
                Categories = categories
            };
            return View(foodAddDto);
        }

        [HttpPost]
        
        public async Task<IActionResult> Create(FoodAddDto foodAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Works.InitUrl(foodAddDto.Name);
                var food = new Food
                {
                    Name = foodAddDto.Name,
                    Material = foodAddDto.Material,
                    Description = foodAddDto.Description,
                    Url = url,
                    IsApproved = foodAddDto.IsApproved,
                    IsHome = foodAddDto.IsHome,
                    ImageUrl = Works.UploadImage(foodAddDto.ImageFile)
                };
                await _foodService.CreateFoodAsync(food, foodAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllAsync();
            foodAddDto.Categories = categories;
            return View(foodAddDto);
        }
    }
}
