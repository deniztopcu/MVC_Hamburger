using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.Models.ViewModels
{
	public class SiparisEkstraMalzemeVM
	{
		public int? EkstraMalzemeId { get; set; }
		public string? EkstraMalzemeAdi { get; set; }
		public decimal? EkstraMalzemeFiyati { get; set; }
        public Kategori? EkstraMalzemeKategori { get; set; }
    }
}
