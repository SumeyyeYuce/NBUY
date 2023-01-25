using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Business.Concrete;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Entity.Concrete.Identity;
using YemekSitesi.Web.Areas.Admin.Models.Dtos;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IFoodService _foodService;
        private readonly UserManager<User> _userManager;

        public CommentController(ICommentService commentService, IFoodService foodService, UserManager<User> userManager)
        {
            _commentService = commentService;
            _foodService = foodService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentAddDto commentAddDto)
        {
            var userId = _userManager.GetUserId(User);
           
            Comment comment = new Comment
            {
                Id=commentAddDto.Id,
                UserId = userId,
                Message = commentAddDto.Message,
                CreatedDate = DateTime.Now,
                FoodId = commentAddDto.FoodId,


                       
            };
            User user = new User
            {
                Id=commentAddDto.UserId,
                FirstName = commentAddDto.FirstName,
                LastName = commentAddDto.LastName
            };
       

            await _commentService.CreateAsync(comment);
            var food= await _foodService.GetByIdAsync(comment.FoodId);
            //var ıd = await _commentService.GetByIdAsync(comment.Id);
            //_foodService.Update(food);
            return RedirectToAction("FoodDetails", "Food",new{ foodurl = food.Url});    
        }

        public async Task<IActionResult> Delete(int id)
        {
            Comment comment1 = await _commentService.GetByIdAsync(id);
            _commentService.Delete(comment1);
            var food = await _foodService.GetByIdAsync(comment1.FoodId);
            return RedirectToAction("FoodDetails", "Food", new { foodurl = food.Url });
        }
    }
}









