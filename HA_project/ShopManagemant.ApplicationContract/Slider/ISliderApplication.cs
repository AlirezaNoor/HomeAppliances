using _0_Framework.Application;

namespace ShopManagemant.ApplicationContract.Slider
{
    public interface ISliderApplication
    {
        OperationResult Create(CreateSlider command);
        void Edited(EditSlider command);
        EditSlider filedblank(long id);
        List<SliderViewModel> getAll();
        void Removed(long id);
        void Restore(long id);
    }
}
