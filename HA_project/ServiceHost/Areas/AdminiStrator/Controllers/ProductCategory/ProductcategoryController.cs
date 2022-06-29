using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ServiceHost.Areas.AdminiStrator.Models.ProductCategory;
using ShopManagemant.ApplicationContract.ProductCategory;

namespace ServiceHost.Areas.AdminiStrator.Controllers.ProductCategory
{
    [Area("AdminiStrator")]
    public class ProductcategoryController : Controller
    {
        private readonly IProductCategoryApplication _application;

        public ProductcategoryController(IProductCategoryApplication application)
        {
            _application = application;
        }

        public IActionResult Index(ProductCategoryView command)
        {
            var model = new ProductCategoryView();

            model.ProductCategory = _application.All(command.Search);
            return View(model);
        }
        [HttpPost]
        public IActionResult sendTodatabase(ProductCategoryView command)
        {
            _application.Create(command.create);
            return RedirectToAction("Index");
        }

        public IActionResult Editeds(long id)
        {
            var model = new ProductCategoryView();
           model.Edited= _application.fildinput(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Editeds(ProductCategoryView command)
        {
            _application.Edited(command.Edited);
            return RedirectToAction("Index");
        }

    }
}
