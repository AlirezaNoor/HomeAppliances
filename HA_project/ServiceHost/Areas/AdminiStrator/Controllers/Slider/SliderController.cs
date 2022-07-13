using Microsoft.AspNetCore.Mvc;
using ServiceHost.Areas.AdminiStrator.Models.Slider;
using ShopManagemant.ApplicationContract.Slider;

namespace ServiceHost.Areas.AdminiStrator.Controllers.Slider
{
    [Area("AdminiStrator")]
    public class SliderController : Controller
    {
        private readonly ISliderApplication _application;

        public SliderController(ISliderApplication application)
        {
            _application = application;
        }

        public IActionResult Index()
        {
            var model = new SliderModels();
            model.Slider = _application.getAll();
            return View(model);
        }

        public IActionResult sendTodatabase()
        {
            return View();
        }
        [HttpPost]
        public IActionResult sendTodatabase(SliderModels command)
        {
            _application.Create(command.createslider);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.getAll()) });

        }

        public IActionResult Remove(long id)
        {
            _application.Removed(id);
            return RedirectToAction("Index");
        }

        public IActionResult Restore(long id)
        {
            _application.Restore(id);
            return RedirectToAction("Index");
        }

        public IActionResult Editeds(long id)
        {
            var model = new EditSlider();
            model=_application.filedblank(id);
            return View(model);

        }
        [HttpPost]
        public IActionResult Editeds(EditSlider command)
        {
         _application.Edited(command);

         return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _application.getAll()) });

        }
    }
}
