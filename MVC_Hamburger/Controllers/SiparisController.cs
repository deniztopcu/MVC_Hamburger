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
          model = new SiparisVM();

		}
        SiparisVM model;
        public IActionResult Index(int id)
        {
			Menu menu = _context.Menuler.FirstOrDefault(x => x.ID == id);
            model.Kategoriler=_context.Kategoriler.ToList();
            model.Icecekler = GetEkstraById(1);
            model.Tatlilar = GetEkstraById(2);
            model.Soslar = GetEkstraById(3);
            model.CitirLezzetler = GetEkstraById(4);
			model.Menu = menu;
			return View(model);
        }
        public SelectList GetEkstraById(int id)
        {
			SelectList ekstramalzemeler = new SelectList (_context.EkstraMalzemeler.Where(x => x.KategoriID == id).ToList(),"ID","Ad");
            return ekstramalzemeler;
		}

    }
}
