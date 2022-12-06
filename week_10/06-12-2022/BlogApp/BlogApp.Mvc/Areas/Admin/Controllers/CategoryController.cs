using BlogApp.Entities.Dtos;
using BlogApp.Mvc.Areas.Admin.Models;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            var result=await _categoryService.GetAllByNonDeleted();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");//geriye bir partialView dönderir
        }
       
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Add(categoryAddDto,"Süm");
                if (result.ResultStatus==ResultStatus.Success)
                {
                    
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto=result.Data,
                        CategoryAddPartial=await this.RenderViewToStringAsync("_CategoryAddPartial",categoryAddDto)

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
    
       
        public async Task<JsonResult> GetAllCategories()
        {
            var result = await _categoryService.GetAllByNonDeleted();//categoriService den GetAll metodunu çagırıdk(burası GetAll dı sonra GetAllByNonDeleted bunula değiştirdik )
            var resultJson = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(resultJson);

        }


        [HttpPost]    
        public async Task<JsonResult> Delete (int categoryId)
        {
            var result = await _categoryService.Delete(categoryId, "Süm");//bilgiyi aldık
            var resultJson = JsonSerializer.Serialize(result);//json'a seeilaze et diyoruz
            return Json(resultJson);
        }

    
        public async Task<IActionResult> Update (int categoryId)
        {
            var result = await _categoryService.GetCategoryUpdateDto(categoryId);
            if (result.ResultStatus==ResultStatus.Success)
            {
                return PartialView("_CategoryUpdatePartial",result.Data);//bu partial döndür
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Update(categoryUpdateDto, "süm");
                if (result.ResultStatus==ResultStatus.Success)
                {
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new CategoryUpdateAjaxViewModel
                    {
                        CategoryDto=result.Data,
                        CategoryUpdatePartial=await this.RenderViewToStringAsync("_CategoryUpdatePartial",categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new CategoryUpdateAjaxViewModel
            {
                
                CategoryUpdatePartial = await this.RenderViewToStringAsync("_CategoryUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        
    }
}
