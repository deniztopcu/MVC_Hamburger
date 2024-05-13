using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;
using System.ComponentModel;

namespace MVC_Hamburger.Models.ViewModels
{
    public class EkstraMalzemeVM
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public EkstraMalzeme? EkstraMalzeme { get; set; }
        public List<EkstraMalzeme>? EkstraMalzemeler { get; set; }
    }
}
