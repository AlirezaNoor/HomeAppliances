using DiscountManegmant.ApplicationContartct.ColleagueDiscountApplicationconteract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.AdminiStrator.Models.ColleagueDiscount;
using ShopManagemant.ApplicationContract.Product;

namespace ServiceHost.Areas.AdminiStrator.Controllers.ColleagueDiscount
{
    [Area("AdminiStrator")]
    public class ColleagueDiscountController : Controller
    {
        private readonly IColleagueDiscountApplication _colleagueDiscountApplication;
        private readonly IProductApplication _productApplication;

        public ColleagueDiscountController(IColleagueDiscountApplication colleagueDiscountApplication, IProductApplication productApplication)
        {
            _colleagueDiscountApplication = colleagueDiscountApplication;
            _productApplication = productApplication;
        }

        public IActionResult Index()
        {
            var model = new ColleagueDiscountModels();
            model.All = _colleagueDiscountApplication.all();
            return View(model);
        }

        public IActionResult sendTodatabase()
        {
            var model = new ColleagueDiscountModels();
            model.list = new SelectList(_productApplication.getList(), "id", "Name");
            return View(model);
        }
        [HttpPost]
        public IActionResult sendTodatabase(ColleagueDiscountModels command)
        {
            _colleagueDiscountApplication.create(command.create);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _colleagueDiscountApplication.all()) });


        }

        public IActionResult Editeds(long id)
        {
            var model = new ColleagueDiscountModels();
            model.Edited = _colleagueDiscountApplication.dtails(id);
            model.list = new SelectList(_productApplication.getList(), "id", "Name", model.Edited.ProductId);
            return View(model);
        }
        [HttpPost]
        public IActionResult Editeds(ColleagueDiscountModels command)
        {
            _colleagueDiscountApplication.Edited(command.Edited);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _colleagueDiscountApplication.all()) });

        }
    }
}
