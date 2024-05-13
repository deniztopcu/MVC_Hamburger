namespace MVC_Hamburger.Models.Concrete
{
    public class EkstraMalzemeMenu
    {
        public int EkstraMalzemeID { get; set; }
        public EkstraMalzeme EkstraMalzeme { get; set; }
        public int MenuID { get; set; }
        public Menu Menu { get; set; }
    }
}
