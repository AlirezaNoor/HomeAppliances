using ShopManagemant.ApplicationContract.Slider;

namespace ServiceHost.Areas.AdminiStrator.Models.Slider
{
    public class SliderModels
    {
        public List<SliderViewModel> Slider { get; set; }
        public CreateSlider createslider { get; set; }
        public EditSlider Edit { get; set; }
    }
}
