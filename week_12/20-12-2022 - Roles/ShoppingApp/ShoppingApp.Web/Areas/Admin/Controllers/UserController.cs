using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            List<UserDto> users = _userManager.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Email = u.Email,
                EmailConfirmed = u.EmailConfirmed
            }).ToList();
            ViewBag.SelectedMenu = "User";
            ViewBag.Title = "Kullanıcılar";
            return View(users);
        }

        public IActionResult Create()
        {
            UserAddDto userAddDto = new UserAddDto
            {
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description,
                }).ToList(),
                SelectedRoles = new List<string>()
            };
            ViewBag.Title = "Kullanıcı Oluştur";
            return View(userAddDto);//bunu içinde hem role var hmede boş bir selectedRoles var 
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserAddDto userAddDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userAddDto.UserDto.FirstName,
                    LastName = userAddDto.UserDto.LastName,
                    UserName = userAddDto.UserDto.UserName,
                    Email = userAddDto.UserDto.Email,
                    EmailConfirmed = userAddDto.UserDto.EmailConfirmed
                };
              var result= await _userManager.CreateAsync(user,"Qwe123.");
                if (result.Succeeded)
                {
                    await _userManager.AddToRolesAsync(user, userAddDto.SelectedRoles);
                    TempData["Message"] = Jobs.CreateMessage("Başarılı", $"{user.UserName} kullanıcısı başarıyla oluştruldu", "success");
                    return RedirectToAction("Index", "User");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userAddDto.Roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
            }).ToList();
            userAddDto.SelectedRoles = userAddDto.SelectedRoles ?? new List<string>();//eger boşsa bş string yolla (kullanıcıyı seçili getirir)
            return View(userAddDto);
        }
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user==null)
            {
                return NotFound();
            }
            UserAddDto userUpdateDto = new UserAddDto
            {
                UserDto = new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    UserName = user.UserName,
                },
                SelectedRoles = await _userManager.GetRolesAsync(user),
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description,
                }).ToList()
        };
            return View(userUpdateDto);
        }
    }
}
