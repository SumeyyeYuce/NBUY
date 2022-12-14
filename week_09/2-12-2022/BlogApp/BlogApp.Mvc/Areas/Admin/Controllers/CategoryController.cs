using BlogApp.Entities.Dtos;
using BlogApp.Mvc.Areas.Admin.Models;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    //categoryAddAjaxModel bu bir obje 
    [Area("Admin")]
    public class CategoryController : Controller
    {
        //Dependenci Injeksin yaparak ctor açıyoruz
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
        //buarayı düzenlemaya başladık 3. olarak burdan index' e döndük ordaki json kodları (devam)
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)//hiçbir hata yoksa add işlemini yap diyoruz
            {
                var result = await _categoryService.Add(categoryAddDto,"Süm");
                if (result.ResultStatus==ResultStatus.Success)//yukarıdan gelen result resultStatus.success eşitse
                {
                    //bu işlemleri yapsın dedik
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto=result.Data,//veri burda
                        CategoryAddPartial=await this.RenderViewToStringAsync("_CategoryAddPartial",categoryAddDto)//partial viewi json olarak dönüştürücek(yani strine dönüştür)

                    });
                    return Json(categoryAddAjaxModel);//json a dönüştürüp geri dönder
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
               
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)//partial viewi json olarak dönüştürücek(yani strine dönüştür)

            });
            return Json(categoryAddAjaxErrorModel);//json a dönüştürüp geri dönder

        }
    }
}
