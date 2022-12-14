using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
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
        public IActionResult Create()//bu metodun varlık sebebi kategorileri girilmesi gereken formu açıcak
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                //modelState is valid aşşagdıaki  işlemleri yapıp kayıt yapıcak valide değilse kategori indexsin gitsin
                //valid oldugunda da gitsin
                var category = new Category
                {
                    Name = categoryAddDto.Name,
                    Description = categoryAddDto.Description,
                    Url=Jobs.InitUrl(categoryAddDto.Name)

                };
                await _categoryService.CreateAsync(category);

                return RedirectToAction("Index");//yukarıdaki işlemlmer bitince tekrar index' e gelsin
                //return RedirectToAction(nameof(Index));
            }
            return View();//bu creat.cshtml'i çagırır
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);//ilgili kategoriyi bulup getiricek
            if (category==null)//kategori bilgiis boşsa hata mesajı ver
            {
                return NotFound();
            }
            var categoryUpdateDto = new CategoryUpdateDto
            {
                Id=category.Id,
                Name = category.Name,
                Description = category.Description,
                Url = category.Url
            };
            return View(categoryUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var category = await _categoryService.GetByIdAsync(categoryUpdateDto.Id);//dışarıdan gelen 
                if (category==null)
                {
                    return NotFound();
                }
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Url = Jobs.InitUrl(categoryUpdateDto.Name);
                
                _categoryService.Update(category);//yukarıda oluşturudgumuz category yi update etmesi için yolladık
                return RedirectToAction("Index");
            }
            return View(categoryUpdateDto);//eger isvalid boş dönerse categoryUpdatDto daki hata mesajlarını göstererk döndür diyoruz
        }

        [HttpGet]//herhanbgi bir formun içinde olmaıgımız için post yapmadık get yaptık
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _categoryService.Delete(category);
            return RedirectToAction("Index");
        }

      
      
    }
}
