using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.UI.Controllers
{
    public class CouponsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
