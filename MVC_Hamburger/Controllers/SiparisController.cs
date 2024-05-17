using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MVC_Hamburger.Controllers
{
	public class SiparisController : Controller
	{
        private readonly HamburgerDbContext _context;
        private readonly UserManager<Uye> _userManager;

        public static List<SiparisVM> sepettekiSiparisler=new List<SiparisVM>();
        public SiparisController(HamburgerDbContext context, UserManager<Uye> userManager)
        {
            _context = context;
            model = new SiparisVM();
            this._userManager = userManager;

        }
        SiparisVM model;

        public IActionResult SepeteEkle(int? id)
        {
            model.GelenMenu = _context.Menuler
                .Where(sm => sm.ID == id)
                .Select(sm => new SiparisMenuVM
                {
                    MenuId = sm.ID,
                    MenuAdi = sm.Ad,
                    MenuFiyati = sm.Fiyat,
                    MenuResimYolu = sm.ResimYolu,
                    MenuIcerik = sm.Icerik
                })
                .FirstOrDefault();

            model.GelenMenulerSL = new SelectList(_context.Menuler.Where(x => x.ID == id).ToList(), "ID", "Ad");



            var kategoriler = _context.Kategoriler.Include(c => c.EkstraMalzemeler).ToList();
            foreach (var category in kategoriler)
            {
                if (category.KategoriAdi == "Sos")
                {
                    var categoryViewModel1 = new EMKategoriVM
                    {
                        KategoriID = category.KategoriID,
                        KategoriAdi = $"1.{category.KategoriAdi} Seçimi",
                        EkstraMalzemeler = new SelectList(category.EkstraMalzemeler, "ID", "Ad")
                    };

                    var categoryViewModel2 = new EMKategoriVM
                    {
                        KategoriID = category.KategoriID,
                        KategoriAdi = $"2.{category.KategoriAdi} Seçimi",
                        EkstraMalzemeler = new SelectList(category.EkstraMalzemeler, "ID", "Ad")
                    };
                    model.EMKategoriler.Add(categoryViewModel1);
                    model.EMKategoriler.Add(categoryViewModel2);
                }
                else
                {
                    var categoryViewModel = new EMKategoriVM
                    {
                        KategoriID = category.KategoriID,
                        KategoriAdi = category.KategoriAdi,
                        EkstraMalzemeler = new SelectList(category.EkstraMalzemeler, "ID", "Ad")
                    };

                    model.EMKategoriler.Add(categoryViewModel);
                }

            }

            return View(model);
        }
        [HttpPost]
        public IActionResult SepeteEkle(SiparisVM siparisVm)
        {
            sepettekiSiparisler.Add(siparisVm);
            SiparisMenu menu = new SiparisMenu();
            menu.MenuID = siparisVm.SecilenMenu.ID;

            //menu.SiparisID=siparis.ID;
            //menu.MenuAdedi = siparisVm.MenuAdedi;
            //siparis.SiparisMenuler.Add(menu);
            //siparis.ToplamFiyat += siparisVm.SecilenMenu.Fiyat*siparisVm.MenuAdedi;
            //siparis.Boy = siparisVm.SecilenBoy;
            //siparis.UyeID = GetUserID();


            //foreach(var item in siparisVm.EMKategoriler)
            //{
            //    SiparisEkstraMalzeme malzeme = new SiparisEkstraMalzeme();
            //    malzeme.SiparisID = siparis.ID;
            //    malzeme.EkstraMalzemeID = item.SecilenEkstraMalzemeID;
            //    siparis.ToplamFiyat += GetEmFiyatById(item.SecilenEkstraMalzemeID);
            //    siparis.SiparisEkstraMalzemeler.Add(malzeme);

            //}








            return RedirectToAction("Index", "Home");
        }
        public int GetUserID()
        {
            return int.Parse(_userManager.GetUserId(User));
        }

        public decimal GetEmFiyatById(int id)
        {
            return _context.EkstraMalzemeler.Find(id).Fiyat;
        }

    }
}
