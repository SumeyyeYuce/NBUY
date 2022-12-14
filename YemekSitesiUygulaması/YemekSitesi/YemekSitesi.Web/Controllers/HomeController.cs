using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers;

public class HomeController : Controller
{
    private readonly IFoodService _foodManager;

    public HomeController(IFoodService foodManager)
    {
        _foodManager = foodManager;
    }

    public async Task<IActionResult> Index()
    {
        List<Food> foods = await _foodManager.GetHomePageFoodsAsync();
        List<FoodDto> foodDto= new List<FoodDto>();
        foreach (var food in foods)
        {
            foodDto.Add(new FoodDto
            {
                Id= food.Id,
                Name=food.Name,
                DateAdded= DateTime.Now,
                CookingTime=food.CookingTime,
                ImageUrl=food.ImageUrl
            });
        }
        return View(foodDto);
    }

   
}
