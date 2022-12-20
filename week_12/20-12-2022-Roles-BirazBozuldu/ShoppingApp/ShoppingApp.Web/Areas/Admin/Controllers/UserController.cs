using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IEmailSender _emailSender;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            //Tüm user ları alma işlemi
            List<UserDto> users = _userManager.Users.Select(u => new UserDto
            {
                Id= u.Id,   
                FirstName= u.FirstName, 
                LastName= u.LastName,   
                UserName= u.UserName,
                Email= u.Email,
                EmailConfirmed= u.EmailConfirmed,
            }).ToList();
            ViewBag.SelectedMenu = "User";
            ViewBag.Title = "Kullanıcılar";
            return View(users);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName= userDto.FirstName,
                    LastName= userDto.LastName,
                    UserName= userDto.UserName,
                    Email= userDto.Email,
                    EmailConfirmed= userDto.EmailConfirmed
                   
                };
                await _userManager.CreateAsync(user);
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult KayıtOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KayıtOl(UserKayıtDto userKayıtDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userKayıtDto.FirstName,
                    LastName = userKayıtDto.LastName,
                    UserName = userKayıtDto.UserName,
                    Email = userKayıtDto.Email
                };
                var result = await _userManager.CreateAsync(user, userKayıtDto.Password);
                if (result.Succeeded)
                {
                    //Generate token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "User", new
                    {
                        userId = user.Id,
                        token = tokenCode
                    });
                    Console.WriteLine(url);
                    //Mailin gönderilme, onaylanma vs
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1><br><p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:7215{url}'>Onay linki</a>");
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Lütfen mail hesabınızı kontrol edin. Gelen linki tıklayarak, hesabınızı onaylayın.", "warning");
                    return RedirectToAction("Login", "User");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz");
            return View(userKayıtDto);
        }
    }
}
