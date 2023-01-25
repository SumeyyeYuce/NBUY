using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Core;
using YemekSitesi.Entity.Concrete;
using YemekSitesi.Web.Areas.Admin.Models.Dtos;

namespace YemekSitesi.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            var categoryListDto = new CategoryListDto
            {
                Categories = categories
            };
            ViewBag.SelectedMenu = "Category";
            ViewBag.Title = "Kategoriler";
            return View(categoryListDto);
        }

       
        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }

       
        [HttpPost]    
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var category = new Category
                {
                    Name= categoryAddDto.Name,  
                    Description = categoryAddDto.Description,
                    Url=Works.InitUrl(categoryAddDto.Name)
                };
                await _categoryService.CreateAsync(category);
                return RedirectToAction("Index");
            }
            return View();
        }

       
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category==null)
            {
                return NotFound();
            }
            var categoryUpdateDto = new CategoryUpdateDto
            {
                Name = category.Name,
                Description = category.Description,
                Id = category.Id,
                Url = category.Url

            };
            return View(categoryUpdateDto);
        }

        
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var category = await _categoryService.GetByIdAsync(categoryUpdateDto.Id);
                if (category==null) { return NotFound(); }    
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Url = Works.InitUrl(categoryUpdateDto.Name);

                _categoryService.Update(category);
                return RedirectToAction("Index");

            }
            return View(categoryUpdateDto);  
        }

       
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            
            var category = await _categoryService.GetByIdAsync(id);
            if (category==null) { return NotFound();}
            _categoryService.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
