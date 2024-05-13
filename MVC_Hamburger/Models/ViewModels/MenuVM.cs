using MVC_Hamburger.Models.Concrete;

namespace MVC_Hamburger.Models.ViewModels
{
    public class MenuVM
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public IFormFile Resim { get; set; }
        public Menu Menu { get; set; }
        public List<Menu> Menuler { get; set; }
    }
}
