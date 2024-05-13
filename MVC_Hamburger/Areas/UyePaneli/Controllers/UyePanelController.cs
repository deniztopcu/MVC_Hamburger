using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.Areas.UyePaneli.Controllers
{
    [Area("UyePaneli")]
    public class UyePanelController : Controller
    {
        private readonly UserManager<Uye> _userManager;

        public UyePanelController(UserManager<Uye> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //ViewBag.ID = GetUserID();
            return View();
        }

        public int GetUserID()
        {
            return int.Parse(_userManager.GetUserId(User));
        }
    }
}
