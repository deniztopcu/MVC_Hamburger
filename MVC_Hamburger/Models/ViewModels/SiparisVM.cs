namespace MVC_Hamburger.Models.ViewModels
{
	public class SiparisVM
	{
		public int SiparisId { get; set; }
		public decimal ToplamFiyat { get; set; }
		public int UyeID { get; set; }
		public ICollection<SiparisMenuVM> SiparisMenuler { get; set; }
		public ICollection<SiparisEkstraMalzemeVM> SiparisEkstraMalzemeler { get; set; }
	}
}
