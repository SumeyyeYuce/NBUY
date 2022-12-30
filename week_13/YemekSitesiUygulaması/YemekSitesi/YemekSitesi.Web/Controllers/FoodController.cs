using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodManager;

        public FoodController(IFoodService foodManager)
        {
            _foodManager = foodManager;
        }

        public async Task<IActionResult> FoodList(string categoryurl)
        {
            List<Food> foods = await _foodManager.GetFoodsByCategoryAsync(categoryurl);
            List<FoodDto> foodDtos = new List<FoodDto>();
            foreach (var food in foods)
            {
                foodDtos.Add(new FoodDto 
                {
                   Id=food.Id,
                   Name=food.Name,
                   CookingTime=food.CookingTime,
                   ImageUrl=food.ImageUrl,
                   Url=food.ImageUrl,


                });
            }
            return View(foodDtos);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
