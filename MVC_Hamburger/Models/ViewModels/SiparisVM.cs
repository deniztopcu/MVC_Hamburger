using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.Models.ViewModels
{
	public class SiparisVM
	{
		public int? SiparisId { get; set; }
		public decimal? ToplamFiyat { get; set; }
		public int? UyeID { get; set; }
		public ICollection<SiparisEkstraMalzemeVM>? SiparisEkstraMalzemeler { get; set; }
		public SiparisMenuVM? SecilenMenu { get; set; }
        public Boy? Boy { get; set; }

        // Ekstra malzeme kategorileri
        public ICollection<Kategori>? EkstraMalzemeKategori { get; set; }

		// Kategoriye göre ekstra malzemelerin seçim listeleri
		public Dictionary<int, SelectList>? EkstraMalzemelerinKategorisi { get; set; }
	}
}
