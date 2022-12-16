using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ShoppingApp.Core;
using ShoppingApp.Data.Concrete.EfCore.Repositories;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers
{
    [AutoValidateAntiforgeryToken]//burdaki post metotlarında çalışır
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

        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginDto
            { 
                ReturnUrl = returnUrl
            
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user==null)//kullanıcı boşsa
                {
                  
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
                    return View(loginDto);//login dto dakileri gönder diyoruz
                }

                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    TempData["Message"] = Jobs.CreateMessage("bilgi", "Hesabınız onaylanmamş maile gelen onay linkine tıkla", "warning");
                    return View(loginDto);
                }
                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);//buarada user password istiyoruz
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/"); //returnUrl dolu gelmişsse returnUrle git gelmmeişse anasayfaya git
                }
                ModelState.AddModelError("", "Email adresi ya da parola hatalı");
            }
            return View(loginDto);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//bu özellik sadece benim bilgisarımdan gelen cookie bilgisni geçerli olmasını saglıyor
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = registerDto.FirstName,
                    LastName = registerDto.LastName,
                    UserName = registerDto.UserName,
                    Email = registerDto.Email
                };
            var result = await _userManager.CreateAsync(user,registerDto.Password);//kullanıcını giridği paraloya hashleryek yaratır
                if (result.Succeeded)//kullaıcı oluşturma başarılıysa
                {
                    //Generate Token(mail onayı için)
                    var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var url = Url.Action("ConfirmEmail", "Account", new
                    {
                        userId=user.Id,
                        token=tokenCode
                    });
                    Console.WriteLine(url);
                    //mailin gönderilme onaylanma işlemlerir
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap onaylama",
                    $"<h1>Merhaba</h1<br><p>Lütfen hesabınızı onaylamak için aşağıdaki linke tıklayınız</p><a href='https://localhost:7215{url}'>link</a>");
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Lütfen mail hesabınızı kontrol ediniz gelen linki tıklayarak onaylayın", "warning");
                    return RedirectToAction("Login","Account");
                }
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata oluştu lütfen tekrar deneyiniz");
            return View(registerDto);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> ConfirmEmail(string userId,string token)
        {
            if (userId==null || token==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Bilgi", "Geçersiz user ya da token bilgisi", "danger");
               
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);//user ve token bilgileri eşleşiyorsa
                if (result.Succeeded) 
                {
                    TempData["Message"] = Jobs.CreateMessage("Bilgi", "Hesabınız başarıyla onaylandı", "success");
                    return RedirectToAction("Login", "Account");

                }
                return View();
            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun olştu ve hesabınız onaylanmadı tekrar deneyiniz", "danger");

            
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "lütfen mail adresinizi eksiksiz bir şekilde girinzi", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "böyle bir mail adresi bulunamadı yeniden deneyin", "danger");
                return View();
            }
            var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                token = tokenCode
            });
            await _emailSender.SendEmailAsync(
                email,
                "ShoppingApp şifre sıfırlama linki",
                $"Lütfen parolanızı yenilemek için <a href='https://localhost:7215{url}'>Tıklayınız</a>"               
                );
            TempData["Message"] = Jobs.CreateMessage("Bilgi", "Şifre sıfırlama linki mailinze gönderildi mailini kontrol et", "info");

            return RedirectToAction("Login","Account");
        }

        public IActionResult ResetPassword(string userId,string token)
        {
            if (userId==null || token==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Bir sorun oluştu lütfen daha sonra tekrar deneyiniz", "danger");
                return RedirectToAction("Index", "Home");
            }
            var resetPasswordDto = new ResetPasswordDto
            {
                Token = token
            };
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            if (!ModelState.IsValid) 
            {
                return View(resetPasswordDto);
            }
            var user = await _userManager.FindByEmailAsync(resetPasswordDto.Email);
            if (user==null)
            {
                TempData["Message"] = Jobs.CreateMessage("Hata", "Böyle bir kullanıcı bulunamdı", "danger");
                return View(resetPasswordDto);

            }
            var result = await _userManager.ResetPasswordAsync(user,resetPasswordDto.Token,resetPasswordDto.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = Jobs.CreateMessage("Başarılı", "Parolanız başarıyla değiştirlmiştir girş yapmayı deneybirsiniz", "success");
                return RedirectToAction("Login", "Account");

            }
            TempData["Message"] = Jobs.CreateMessage("Hata", "Bir hata oluştu admn ile iletşime geç", "danger");
            return Redirect("~/");
        }
    }
}
