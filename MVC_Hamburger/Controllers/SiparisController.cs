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

        public static List<SepetDTO> sepettekiSiparisler=new List<SepetDTO>();
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

            
            SepetDTO sepetDTO = new SepetDTO();
            sepetDTO.UyeID = GetUserID();
            var ekstraMalzemeler = _context.EkstraMalzemeler.Include(x => x.Kategori).ToList();
            List<int> emIdler = siparisVm.SecilenEkstraMalzemeIDler.Select(int.Parse).ToList();
            sepetDTO.EkstraMalzemeIdler = emIdler;  
            string emDetay = "";
            decimal emToplam = 0;
            foreach(var item in ekstraMalzemeler)
            {
                if (emIdler.Contains(item.ID))
                {
                    emDetay += $" Seçilen {item.Kategori.KategoriAdi}:{item.Ad} Fiyat:{item.Fiyat.ToString("0.##")} TL";
                    emToplam += item.Fiyat;
                }
            }

            sepetDTO.EkstraMalzemeDetay= emDetay;
            sepetDTO.MenuAdedi = siparisVm.MenuAdedi;

            sepetDTO.SiparisBoyu = siparisVm.SecilenBoy;
            
            sepetDTO.SepetMenu = _context.Menuler.Find(siparisVm.SecilenMenu.ID);

            sepetDTO.SepetID = siparisVm.SiparisVMID;

            sepetDTO.SiparisFiyati = (sepetDTO.SepetMenu.Fiyat * sepetDTO.MenuAdedi) + emToplam;

            sepettekiSiparisler.Add(sepetDTO);

            
            
            
            //SiparisMenu menu = new SiparisMenu();
            //menu.MenuID = siparisVm.SecilenMenu.ID;

            //foreach (var ekstraMalzeme in siparisVm.SecilenEkstraMalzemeIDler)
            //{
            //    var newEntity = new SiparisEkstraMalzeme
            //    {
            //        SiparisID = siparisVm.SiparisVMID,
            //        EkstraMalzemeID = Convert.ToInt32(ekstraMalzeme)
            //    };
            //}

            return RedirectToAction("SepetListele", "Siparis");
        }

        public IActionResult SepetListele(List<SepetDTO> siparisler)
        {
            siparisler = sepettekiSiparisler;

            decimal toplamFiyat= 0;
            

            foreach (var item in siparisler) 
            { 

                toplamFiyat+=item.SiparisFiyati;
            }
            ViewBag.ToplamFiyat= toplamFiyat.ToString("0.##");
            return View(siparisler);    
        }

        public IActionResult SiparisOnayla()
        {

            foreach (var item in sepettekiSiparisler)
            {
                Siparis yeniSiparis = new Siparis();
                yeniSiparis.MenuID = item.SepetMenu.ID;
                yeniSiparis.MenuAdedi = item.MenuAdedi;
                yeniSiparis.ToplamFiyat = item.SiparisFiyati;
                yeniSiparis.UyeID = item.UyeID;
                yeniSiparis.Boy = item.SiparisBoyu;

                // Önce Siparişi Ekle
                _context.Siparisler.Add(yeniSiparis);
                _context.SaveChanges(); // Bu aşamada ID değeri oluşturulmuş olacak

                // Eklenen siparişin ID değerini kullanarak ekstra malzemeleri ekle
                foreach (var emID in item.EkstraMalzemeIdler)
                {
                    SiparisEkstraMalzeme sem = new SiparisEkstraMalzeme();
                    sem.SiparisID = yeniSiparis.ID;
                    sem.EkstraMalzemeID = emID;
                    _context.SiparisEkstraMalzemeler.Add(sem);
                }

                _context.SaveChanges(); // Ekstra malzemeleri kaydet
            }

            return RedirectToAction("Burgerler", "Home");
        }

        public IActionResult Siparislerim()
        {

            var uyeSiparisler = _context.Siparisler.Where(x=>x.UyeID==GetUserID()).ToList();
            foreach(var item in uyeSiparisler)
            {
                item.Menu = _context.Menuler.Find(item.MenuID);
                item.SiparisEkstraMalzemeler = _context.SiparisEkstraMalzemeler.Where(x => x.SiparisID == item.ID).ToList();
            }
            return View(uyeSiparisler);
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
