using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Areas.AdminiStrator.Controllers
{
    [Area("AdminiStrator")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
