using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVC_Hamburger.Models.ViewModels
{
    public class SiparisVM
    {
        public Siparis Siparis { get; set; }
        public List<Siparis> Siparisler { get; set; }
        public Kategori Kategori { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public EkstraMalzeme EkstraMalzeme { get; set; }
		public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
		public SelectList? Soslar { get; set; }
        [Display(Name ="İçecekler")]
        public SelectList? Icecekler { get; set; }
		[Display(Name = "Tatlılar")]
		public SelectList? Tatlilar { get; set; }
		[Display(Name = "Çıtır Lezzetler")]
		public SelectList? CitirLezzetler { get; set; }
        public Menu Menu { get; set; }
        public List<Menu> Menuler { get; set; }
    }
}
