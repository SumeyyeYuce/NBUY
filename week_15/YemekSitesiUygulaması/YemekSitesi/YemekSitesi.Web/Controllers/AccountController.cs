using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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


        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;  
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

                    await _emailSender.SendEmailAsync(user.Email, "YemekSitesi Hesap Onaylama", $"<h1>Merhaba</h1>" +
                       $"<br>" +
                       $"<p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız.</p>" +
                       $"<a href='https://localhost:5052{url}'>Tıklayınız</a>");
                    ViewBag.Message = "Kayıt işleminizi tamamlamak için mailinize gönderilen onaylama linkine tıklayınız.";
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
                ViewBag.Message("Geçersiz token ya da user bilgisi!");
                return View();  
            }
            var user =  await _userManager.FindByIdAsync(userId);   
            if (user !=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded) 
                {
                    ViewBag.Message("Hesabınız başarıyla onaylandı.");
                    return View();

                }
            }
            ViewBag.Message("Bir sorun oluştu ve hesabınız onaylanmadı. Tekrar deneyiniz.");
            return View();
        }
        public IActionResult ForgotPas()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPas(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = Works.PushMessage("Hata", "Lütfen mail adresinizi eksiksiz ve doğru girin", "danger");
                return View();   
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                TempData["Message"] = Works.PushMessage("Hata", "Böyle bir mail adresi bulunamadı lüften tekrar deneyin", "danger");
                return View();
            }
            var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPas", "Account", new
            {
                userId = user.Id,
                token = tokenCode
            });
            await _emailSender.SendEmailAsync(

               email,
               "YemekSitesi Şifre Sıfırlama Linki",
                $"Lütfen parolanızı yenilemek için <a href='https://localhost:5052{url}'>Tıklayınız</a>"

               );
            TempData["Message"] = Works.PushMessage("Bilgi", "Şifre sıfırlama linkiniz mailinize gönderildi lütfen mail adresinizi kontrol ediniz", "info");
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult ResetPas(string userId,string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = Works.PushMessage("Hata", "Bir sorun oluştu lütfen daha sonra tekrar deneyiniz", "danger");
                return RedirectToAction("Index", "Home");
            }
            var resetPasDto = new ResetPasDto
            {
                Token = token
            };
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> ResetPas(ResetPasDto resetPasDto)
        {
            if (!ModelState.IsValid)
            {
                return View(resetPasDto);
            }
            var user = await _userManager.FindByEmailAsync(resetPasDto.Email);
            if (user == null) 
            {
                TempData["Message"] = Works.PushMessage("Hata", "Böyle bir kullanıcı bulunamadı", "danger");
                return View(resetPasDto);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasDto.Token, resetPasDto.Password);
            if (result.Succeeded) 
            {
                TempData["Message"] = Works.PushMessage("Başarılı", "Parolanız başarıyla değiştirildi giriş yapabilrsiniz", "success");
                return RedirectToAction("Login", "Account");
            }
            TempData["Message"] = Works.PushMessage("Hata", "Bir hata oluştu", "danger");
            return Redirect("~/");
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
