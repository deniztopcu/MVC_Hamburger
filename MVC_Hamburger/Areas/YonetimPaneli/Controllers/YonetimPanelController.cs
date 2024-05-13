using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Hamburger.Areas.YonetimPaneli.Controllers
{
    [Authorize(Roles = "Yonetici")]
    [Area("YonetimPaneli")]
    public class YonetimPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
