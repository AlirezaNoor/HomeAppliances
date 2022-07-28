using DiscountManegmant.ApplicationContartct.CustomerDiscountApplitionContratct;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.AdminiStrator.Models.Discounts;
using ShopManagemant.ApplicationContract.Product;

namespace ServiceHost.Areas.AdminiStrator.Controllers.CostumerDiscount
{
    [Area("AdminiStrator")]
    public class CustomerDiscountController : Controller
    {
        private readonly ICustomerDiscountApplication _application;
        private readonly  IProductApplication _product;

        public CustomerDiscountController(ICustomerDiscountApplication application, IProductApplication product)
        {
            _application = application;
            _product = product;
        }

        public IActionResult Index()
        {
            var model = new CustomerDiscountModel();
            model.List = _application.GetAll();
            return View(model);
        }

        public IActionResult sendTodatabase()
        {
            var model = new CustomerDiscountModel();
            model.SelectList = new SelectList(_product.getList(), "id", "Name");
            return View(model);

        }
        [HttpPost]
        public IActionResult sendTodatabase(CustomerDiscountModel command)
        {
            _application.Create(command.CreateCustomerDiscount);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.GetAll()) });


        }
    }
}
