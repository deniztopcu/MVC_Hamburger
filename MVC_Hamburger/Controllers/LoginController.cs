using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.ViewModels;

namespace MVC_Hamburger.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<Uye> _signInManager;
        private readonly UserManager<Uye> _userManager;

        public LoginController(SignInManager<Uye> signInManager, UserManager<Uye> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM login)
        {
            var uye = _userManager.FindByEmailAsync(login.Email).Result;

            if (uye == null)
            {
                //eposta kontrolu...
                ModelState.AddModelError("Hata", "Kullanıcı adı veya şifre yanlış...");
                return View();
            }

            if (!_userManager.CheckPasswordAsync(uye, login.Sifre).Result)
            {
                //sifre kontrolu...
                ModelState.AddModelError("Hata", "Kullanıcı adı veya şifre yanlış...");
                return View();
            }

            await _signInManager.SignInAsync(uye, false);

            return RedirectToAction("Index", "Home");
        }

        //[HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            //return RedirectToAction("Index", "Home");
            return Redirect("~/Login/Login");
            //return LocalRedirect("~/localhost:5168/Home/Index");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            //ModelState.ISValid() kontrol et...
            Uye uye = new Uye();
            uye.Adres = register.Adres;
            uye.UserName = register.Email;
            uye.Email = register.Email;

            uye.PasswordHash = _userManager.PasswordHasher.HashPassword(uye, register.Sifre);
            var result = await _userManager.CreateAsync(uye);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(uye, "Musteri");
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
    }
}
