using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.Models.ViewModels
{
    public class SepetDTO
    {
        public int SiparisID { get; set; }

        public decimal SiparisFiyati { get; set; }  

        public decimal  ToplamFiyat { get; set; }

        public string EkstraMalzemeDetay { get; set; }

        public int MenuAdedi {  get; set; } 

        public Boy SiparisBoyu { get; set; }

        public Menu SepetMenu { get; set; }

        public int UyeID { get; set; }  

        public List<int> EkstraMalzemeIdler { get; set; }
    }
}
