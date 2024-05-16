using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.Models.ViewModels
{
	public class SiparisMenuVM
	{
		public int MenuId { get; set; }
		public string MenuAdi { get; set; }
		public decimal MenuFiyati { get; set; }
		public Boy Boy { get; set; }
	}
}
