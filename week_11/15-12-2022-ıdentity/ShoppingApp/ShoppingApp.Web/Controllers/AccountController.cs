using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
                //bu noktada email onayı yapıılıp yapılmadıgnı kontrol edicegiz eger email onaylı ise login yaptıracagız değilse hatıratıcagız
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

                    //mailin gönderilme onaylanma işlemlerir
                    await _emailSender.SendEmailAsync(user.Email, "ShoppingApp Hesap onaylama", $"<h1>Merhaba</h1>" +
                        $"<br>" +
                        $"<p>Lütfen hesabınızı onaylamak için aşşadıdaki lnke  tıklayınız</p>" +
                        $"<a href='https://localhost:5178{url}'></a>");
                    ViewBag.Message = "KAYıt işlemini tamamlamak için mailinze gönderilen onaylama linkine tılayınız";
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
                ViewBag.Messsage("Geçersiz user ya da token bilgisi");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user!=null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);//user ve token bilgileri eşleşiyorsa
                if (result.Succeeded) 
                {
                    ViewBag.Message("Hesabınız başarıyla onaylandı");
                    return View();
                }
            }
            ViewBag.Message("Bir sorun olştu ve hesabınız onaylanmadı tekrar deneyiniz");
            return View();
        }
    }
}
