using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.UI.Controllers
{
    public class ProductSpecsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
