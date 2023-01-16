using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using YemekSitesi.Core;
using YemekSitesi.Entity.Concrete.Identity;
using YemekSitesi.Web.Areas.Admin.Models.Dtos;

namespace YemekSitesi.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            List<UserDto> users = _userManager.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                UserName = u.UserName,
                EmailConfirmed = u.EmailConfirmed
            }).ToList();
            ViewBag.SelectedMenu = "User";
            ViewBag.Title = "Kullanıcılar";
            return View(users);
            
        }

        [HttpGet]

        public IActionResult Create()
        {
            UserAddDto userAddDto = new UserAddDto
            {
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Description = r.Description,
                    Name = r.Name,
                }).ToList(),
                SelectedRoles = new List<string>()
            };
            ViewBag.Title = "Kullanıcı Oluştur";
            return View(userAddDto);
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
                    Email = userAddDto.UserDto.Email,
                    UserName = userAddDto.UserDto.UserName,
                    EmailConfirmed = userAddDto.UserDto.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    await _userManager.AddToRolesAsync(user, userAddDto.SelectedRoles);
                    TempData["Message"] = Works.PushMessage("Başarılı", $"{user.UserName} kullanıcısı başarıyla oluşturuldu", "success");
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
            userAddDto.SelectedRoles = userAddDto.SelectedRoles ?? new List<string>();   
            return View(userAddDto);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
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

        [HttpPost]
        public async Task<IActionResult> Edit(UserAddDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userUpdateDto.UserDto.Id);
                if (user == null) { return NotFound(); }
                user.FirstName = userUpdateDto.UserDto.FirstName;
                user.LastName = userUpdateDto.UserDto.LastName;
                user.Email = userUpdateDto.UserDto.Email;
                user.EmailConfirmed = userUpdateDto.UserDto.EmailConfirmed;
                user.UserName = userUpdateDto.UserDto.UserName;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return NotFound();
                }
                var userRol = await _userManager.GetRolesAsync(user);
                await _userManager.AddToRolesAsync(user, userUpdateDto.SelectedRoles.Except(userRol)
                    .ToList<string>());
                await _userManager.RemoveFromRolesAsync(user, userRol.Except(userUpdateDto.SelectedRoles)
                    .ToList<string>());

                TempData["Message"] = Works.PushMessage("Başarılı", $"{user.UserName} kullanıcısı başarıyla güncellendi", "success");
                return RedirectToAction("Index", "User");
            }
            userUpdateDto.Roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description

            }).ToList();
            userUpdateDto.SelectedRoles = userUpdateDto.SelectedRoles ?? new List<string>();
            return View(userUpdateDto);
        }

        public async Task<IActionResult> Delete (string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user==null)
            {
                return NotFound();
            }
            await _userManager.DeleteAsync(user);
            return RedirectToAction("Index");
        }
    }
}
