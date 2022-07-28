using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.AdminiStrator.Models.Product;
using ShopManagemant.ApplicationContract.Product;
using ShopManagemant.ApplicationContract.ProductCategory;

namespace ServiceHost.Areas.AdminiStrator.Controllers.Product
{
    [Area("AdminiStrator")]
    public class ProductController : Controller
    {
        private readonly IProductApplication _application;
        private readonly IProductCategoryApplication _categoryApplication;

        public ProductController(IProductApplication application, IProductCategoryApplication categoryApplication)
        {
            _application = application;
            _categoryApplication = categoryApplication;
        }

        public IActionResult Index( ProductModels comand)
        {
            var model = new ProductModels();
            model.productviewmodel = _application.search(comand.Search);
            return View(model);
        }

        public IActionResult sendTodatabase()           
        {
            var selectitem = new ProductModels();
            selectitem.Select = new SelectList(_categoryApplication.allcategory(), "Id", "Title");
            return View(selectitem);
        }
        [HttpPost]
        public IActionResult sendTodatabase(ProductModels comand)
        {
            _application.Create(comand.create);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.search(comand.Search)) });

        }

        public IActionResult Editeds(long id)
        {
            var model = new ProductModels();
            model.edit = _application.details(id);
            model.Select = new SelectList(_categoryApplication.allcategory(), "Id", "Title", model.edit.id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Editeds(ProductModels comand)
        {
            _application.Edit(comand.edit);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.search(comand.Search)) });

        }


    }
}
