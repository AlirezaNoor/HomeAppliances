using _0_Framework.Application;
using ShopManagemant.ApplicationContract.Slider;
using ShopManagmant.Domin.Slid;

namespace ShopManagemant.Application.SliderApp
{
    public class SliderApplication : ISliderApplication
    {
        private readonly ISliderReposetory _reposetory;

        public SliderApplication(ISliderReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult Create(CreateSlider command)
        {
            var operation = new OperationResult();
            if (_reposetory.Exist(x => x.title == command.title))
            {
                operation.faild();
            }

            var model = new Slider(command.slidePicture,command.headingTitle, command.title, command.discription,
                command.Btntitle,command.link);
            _reposetory.Create(model);
            _reposetory.Save();
            return operation.Secusees();

        }

        public void Edited(EditSlider command)
        {
        
            var commands = _reposetory.GetById(command.Id);
            commands.Edited(command.slidePicture,command.link, command.headingTitle, command.title, command.discription, command.Btntitle);
            _reposetory.Save();
        }


        public EditSlider filedblank(long id)
        {
            var slider = _reposetory.GetById(id);

            return new EditSlider()
            {
                title = slider.title,
                Btntitle = slider.Btntitle,
                discription = slider.discription,
                headingTitle = slider.headingTitle,
                Id = slider.Id,
                slidePicture = slider.slidePicture,
                link = slider.Link

            };
        }

        public List<SliderViewModel> getAll()
        {
            return _reposetory.GetAll().OrderByDescending(x => x.Id).Select(x => new SliderViewModel()
            {
                id = x.Id,
                Title = x.title,
                ISremove = x.ISRemove,
                picture = x.slidePicture
            }).ToList();
        }

        public void Removed(long id)
        {
            var command = _reposetory.GetById(id);
            command.Remove();
            _reposetory.Save();
        }

        public void Restore(long id)
        {
            var command = _reposetory.GetById(id);
            command.Restore();
            _reposetory.Save();
        }
    }
}
