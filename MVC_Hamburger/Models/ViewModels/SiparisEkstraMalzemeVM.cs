using MVC_Hamburger.Models.Concrete;
using System.ComponentModel.DataAnnotations;

namespace MVC_Hamburger.Models.ViewModels
{
	public class SiparisEkstraMalzemeVM
	{
		public int? EkstraMalzemeId { get; set; }
		public string? EkstraMalzemeAdi { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.##}", ApplyFormatInEditMode = true)]
        public decimal EkstraMalzemeFiyati { get; set; }
        public Kategori? EkstraMalzemeKategori { get; set; }
    }
}
