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

            await _commentService.CreateAsync(comment);
            var food= await _foodService.GetByIdAsync(comment.FoodId);         
            return RedirectToAction("FoodDetails", "Food",new{ foodurl = food.Url});    
        }

        public async Task<IActionResult> Delete(int id)
        {         
            var coment = await _commentService.GetByIdAsync(id);
            if (coment==null)
            {
                return NotFound();
            }
            _commentService.Delete(coment);
            var food = await _foodService.GetByIdAsync(coment.FoodId);
            return RedirectToAction("FoodDetails", "Food", new { foodurl = food.Url });

        }
    }
}









