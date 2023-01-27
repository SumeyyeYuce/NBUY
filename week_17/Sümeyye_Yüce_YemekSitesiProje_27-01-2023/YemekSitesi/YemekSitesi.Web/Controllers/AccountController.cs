using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using YemekSitesi.Business.Abstract;
using YemekSitesi.Core;
using YemekSitesi.Entity.Concrete.Identity;
using YemekSitesi.Web.MailServices.Abstract;
using YemekSitesi.Web.Models.Dtos;

namespace YemekSitesi.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IFavoriteService _favoriteManager;


        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, IFavoriteService favoriteManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _favoriteManager = favoriteManager;
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
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user==null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    TempData["Message"] = Works.PushMessage("Bilgi", "Hesabınız onaylanmamış mailinize gelen onay linkine tıklayınız", "warning");
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
                    UserName = registerDto.UserName,  
                    
                    EmailConfirmed = true   
                };
                var result  = await _userManager.CreateAsync(user,registerDto.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");                 
                    TempData["Message"] = Works.PushMessage("Bilgi", "Hesabınız başarıyla oluşturuldu", "success");
                    return RedirectToAction("Login", "Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu, lütfen tekrar deneyiniz");
            return View(registerDto);
        }

        public async Task<IActionResult> Exit()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = Works.PushMessage("Hata", "Geçersiz  user bilgisi.", "danger");
                return View();
            }
            var user =  await _userManager.FindByIdAsync(userId);   
            if (user !=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded) 
                {
                    TempData["Message"] = Works.PushMessage("Başarılı", "Hesabınız başarıyla onaylandı. Giriş yapabilirsiniz.", "success");
                    return RedirectToAction("Login", "Account");

                }
            }
            TempData["Message"] = Works.PushMessage("Bilgi","Bir sorun oluştu ve hesabınız onaylanmadı. Tekrar deneyiniz.","danger");
            return View();
        }
      
        
        public async Task<IActionResult> Manage(string id)
        {
            var name = id;
            if (String.IsNullOrEmpty(name))
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(name);
            if (user == null) { return NotFound(); }
            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });
            UserManageDto userManageDto = new UserManageDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Gender = user.Gender,
                Email = user.Email,
                UserName = user.UserName,
                GenderSelectList = genderList
            };
            return View(userManageDto);
        }

        [HttpPost]
        public async Task<IActionResult> Manage(UserManageDto userManageDto)
        {
            if (userManageDto == null) { return NotFound(); }
            var user = await _userManager.FindByIdAsync(userManageDto.Id);
            if (user == null) { return NotFound(); }
                 
            user.FirstName = userManageDto.FirstName;
            user.LastName = userManageDto.LastName;
            user.UserName = userManageDto.UserName;
            user.Gender = userManageDto.Gender;
            user.Email = userManageDto.Email;
            user.DateOfBirth = userManageDto.DateOfBirth;


            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                TempData["Message"] = Works.PushMessage("Başarılı!", "Profiliniz başarıyla kaydedilmiştir.", "success");
            }
            List<SelectListItem> genderList = new List<SelectListItem>();
            genderList.Add(new SelectListItem
            {
                Text = "Kadın",
                Value = "Kadın",
                Selected = user.Gender == "Kadın" ? true : false
            });
            genderList.Add(new SelectListItem
            {
                Text = "Erkek",
                Value = "Erkek",
                Selected = user.Gender == "Erkek" ? true : false
            });
            userManageDto.GenderSelectList = genderList;
            return View(userManageDto);
        }
        public IActionResult AccessDenied()
        {

            return View();
        }
    }
}
