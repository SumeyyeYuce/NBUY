using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodManager;
        private readonly ICommentService _commentManager;

        public FoodController(IFoodService foodManager, ICommentService commentManager)
        {
            _foodManager = foodManager;
            _commentManager = commentManager;
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
                    DateAdded = DateTime.Now,
                    ImageUrl =food.ImageUrl,
                   Url=food.Url,


                });
            }
            return View(foodDtos);
        } 

        public async Task<IActionResult> FoodDetails(string foodurl)
        {
            if (foodurl == null)
            {
                return NotFound();
            }
            var food = await _foodManager.GetFoodDetailsByUrlAsync(foodurl);
           
            FoodDetailsDto foodDetailsDto = new FoodDetailsDto
            {
                Id = food.Id,
                Name = food.Name,
                ImageUrl = food.ImageUrl,
                Url = food.Url,
                CookingTime = food.CookingTime,
                Description = food.Description,
                Material = food.Material,
                Categories = food
                    .FoodCategories
                    .Select(fc => fc.Category)
                    .ToList(),
                 Comments = await _commentManager.GetByFoodId(food.Id)
                 


        };
            return View(foodDetailsDto);
        }


        public IActionResult Index() 
        {
            return View();
        }
    }
}
