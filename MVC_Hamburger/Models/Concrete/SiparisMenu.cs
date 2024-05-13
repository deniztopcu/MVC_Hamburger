namespace MVC_Hamburger.Models.Concrete
{
    public class SiparisMenu
    {
        public int SiparisID { get; set; }
        public Siparis? Siparis { get; set; }
        public int MenuID { get; set; }
        public Menu? Menu { get; set; }

    }
}
