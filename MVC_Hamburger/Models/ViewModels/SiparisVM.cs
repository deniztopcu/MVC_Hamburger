using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Hamburger.Models.Concrete;
using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.Models.ViewModels
{
    public class SiparisVM
    {
        public EkstraMalzeme? EkstraMalzeme { get; set; }
        public Menu Menu { get; set; }
        public SelectList? EkstraMalzemeler { get; set; }
        public List<Menu> Menuler { get; set; }
    }
}
