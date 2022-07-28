using _01_Query.Slider.Conteracts;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Components
{
    public class SliderComponent:ViewComponent
    {
        private readonly ISliderQuery _query;

        public SliderComponent(ISliderQuery query)
        {
            _query = query;
        }

        public IViewComponentResult Invoke()
        {
           var slider= _query.GetAll();
            return View("Slider", slider);
        }
    }
}
