using Microsoft.AspNetCore.Mvc;
using ServiceHost.Models;
using System.Diagnostics;
using _01_Query.Productcategory.Contracts;
using _01_Query.Productcategory.Contracts.ProductWithProductcategory;

namespace ServiceHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IproductCategoryQueryModel _query;

        public HomeController(ILogger<HomeController> logger, IproductCategoryQueryModel query)
        {
            _logger = logger;
            _query = query;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dtails(string id)
        {
           var models= _query.GetAllBy(id);
            return View(models);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}