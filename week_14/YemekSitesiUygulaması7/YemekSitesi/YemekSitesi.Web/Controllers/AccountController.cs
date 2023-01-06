using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YemekSitesi.Entity.Concrete.Identity;

using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
      

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginDto { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user==null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password,true,true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı!");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    Email = registerDto.Email,
                    UserName = registerDto.UserName  
                };
                var result  = await _userManager.CreateAsync(user,registerDto.Password);
                if (result.Succeeded)
                {
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId = user.Id,
                        token = tokenCode
                    });

                    //await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap Onaylama", $"<h1>Merhaba</h1>" +
                    //   $"<br>" +
                    //   $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p>" +
                    //   $"<a href='https://localhost:5178{url}'></a>");
                    //ViewBag.Message = "Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.";
                    return RedirectToAction("Login", "Account");
                }
            }
            return View(registerDto);
        }
    }
}
