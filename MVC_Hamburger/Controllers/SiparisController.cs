using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Hamburger.Controllers
{
    public class SiparisController : Controller
    {
        private readonly HamburgerDbContext _context;

        public SiparisController(HamburgerDbContext context)
        {
            _context = context;
		}
        public IActionResult Index(int id)
        {
            return View();
        }

    }
}
