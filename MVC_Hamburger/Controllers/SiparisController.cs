using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
		public IActionResult Index(int? id)
		{
			model.SecilenMenu = _context.Menuler.FirstOrDefault(x => x.ID == id);
			model.EkstraMalzemeKategori = _context.Kategoriler.ToList();


			var ekstraMalzemeler = _context.EkstraMalzemeler.Include(x => x.Kategori).Select(x => new SiparisEkstraMalzemeVM
			{
				EkstraMalzemeId = x.ID,
				EkstraMalzemeAdi = x.Ad,
				EkstraMalzemeFiyati = x.Fiyat,
				EkstraMalzemeKategori = x.Kategori
			}).ToList();
			model.SiparisEkstraMalzemeler = ekstraMalzemeler;
			return View(model);
		}
		public SelectList GetEkstraById(int id)
		{
			SelectList ekstramalzemeler = new SelectList(_context.EkstraMalzemeler.Where(x => x.KategoriID == id).ToList(), "ID", "Ad");
			return ekstramalzemeler;
		}

	}
}
