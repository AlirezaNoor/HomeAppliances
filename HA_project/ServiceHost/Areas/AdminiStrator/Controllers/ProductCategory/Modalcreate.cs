using Microsoft.AspNetCore.Mvc;
using ServiceHost.Areas.AdminiStrator.Models.ProductCategory;
using ShopManagemant.ApplicationContract.ProductCategory;

namespace ServiceHost.Areas.AdminiStrator.Controllers.ProductCategory
{
    public class Modalcreate:ViewComponent
    {


        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View("Modalcreate");
        }

    }
}
