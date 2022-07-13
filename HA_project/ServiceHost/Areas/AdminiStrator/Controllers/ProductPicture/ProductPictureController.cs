using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.AdminiStrator.Models.ProductPictureModels;
using ShopManagemant.ApplicationContract.Product;
using ShopManagemant.ApplicationContract.ProductPicture;
using Create = ShopManagemant.ApplicationContract.ProductPicture.Create;

namespace ServiceHost.Areas.AdminiStrator.Controllers.ProductPicture
{
    [Area("AdminiStrator")]
    public class ProductPictureController : Controller
    {
        private readonly IProductPictureApplication _application;
        private readonly IProductApplication _productApplication;


        public ProductPictureController(IProductPictureApplication application, IProductApplication productApplication)
        {
            _application = application;
            _productApplication = productApplication;
        }

        public IActionResult Index()
        {
            var model = new ProductPictureModel();
           model.productpicture= _application.GetAllpic();
            return View(model );
        }

        public IActionResult sendTodatabase()
        {

            var model = new ProductPictureModel();
            model.selectlist = new SelectList(_productApplication.All(), "id", "Name");
            return View(model);
        }
        [HttpPost]
        public IActionResult sendTodatabase(ProductPictureModel command)
        {
            _application.Create(command.create);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.GetAllpic()) });

        }

        public IActionResult Editeds(long id)
        {
            var model = new ProductPictureModel();
            model.edited = _application.fildTheblunk(id);
            model.selectlist = new SelectList(_productApplication.All(), "id", "Name", model.edited.ProductId);

            return View(model);
        }
        [HttpPost]
        public IActionResult Editeds(ProductPictureModel command)
        {
            _application.Edit(command.edited);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.GetAllpic()) });
        }


    }
}
