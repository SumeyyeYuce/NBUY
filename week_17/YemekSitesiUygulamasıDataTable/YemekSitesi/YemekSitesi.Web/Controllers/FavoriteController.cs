using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Entity.Concrete.Identity;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    [Authorize]
    public class FavoriteController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IFavoriteService _favoriteManager;
        private readonly IFavItemService _favItemManager;

        public FavoriteController(UserManager<User> userManager, IFavoriteService favoriteManager, IFavItemService favItemManager)
        {
            _userManager = userManager;
            _favoriteManager = favoriteManager;
            _favItemManager = favItemManager;
        }

        public async  Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var favorite = await _favoriteManager.GetFavByUserId(userId);

            FavoriteDto favoriteDto = new FavoriteDto
            {
                FavoriteId = favorite.Id,
                FavoriteItems = favorite.FavoriteItems.Select(fi => new FavoriteItemDto
                {
                    FavoriteItemId = fi.Id,
                    FoodId = fi.FoodId,
                    FoodName = fi.Food.Name,
                    ImageUrl = fi.Food.ImageUrl,
                    FoodUrl=fi.Food.Url,
                    FavortiteNumber = fi.FavortiteNumber
                }).ToList()

            };
            return View(favoriteDto);
        }


        [HttpPost]
        public IActionResult AddToFavorite(int foodId, int favortiteNumber)
        {
            var userId = _userManager.GetUserId(User);
            _favoriteManager.AddToFavorite(userId,foodId, favortiteNumber);
            return RedirectToAction("Index", "Favorite");
        }

        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var favItem = await _favItemManager.GetByIdAsync(id);
            _favItemManager.Delete(favItem);
            return RedirectToAction("Index", "Favorite"); 
        }
    }
}
