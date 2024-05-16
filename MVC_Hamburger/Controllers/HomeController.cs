using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Areas.YonetimPaneli.Models.ViewModels;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models;
using MVC_Hamburger.Models.Concrete;
using System.Diagnostics;

namespace MVC_Hamburger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HamburgerDbContext _context;
        public HomeController(HamburgerDbContext context)
        {
            _context = context;
            menuVM = new MenuVM();
		}
        MenuVM menuVM;
		public IActionResult Index()
        {
            menuVM.Menuler= _context.Menuler.ToList();
            return View(menuVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
