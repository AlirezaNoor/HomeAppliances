using _0_Framework.Application;
using ShopManagemant.ApplicationContract.ProductCategory;
using ShopManagmant.Domin.ProductCategory;

namespace ShopManagemant.Application
{
    public class ProductCategoryApplication: IProductCategoryApplication
    {
        private readonly IReposetory _reposetory;

        public ProductCategoryApplication(IReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult Create(Create command)
        {
            var opretaion = new OperationResult();
            if (_reposetory.Exist(x=>x.Title==command.Title))
            {
                return opretaion.faild();
            }
            var slug = command.Slug.Slugify();
            var model = new ProductCategores(command.Title, command.Discription, command.Picture, command.Alt,
                command.ImageTitle, command.Keywords, command.MetaDiscription, slug);
            _reposetory.Create(model);
            _reposetory.Save();
            return opretaion.Secusees();
        }

        public OperationResult Edited(Edited comand)
        {
            var opretaion = new OperationResult();

            if (_reposetory.Exist(x=>x.Title==comand.Title &&x.Id!=comand.Id))
            {
                return opretaion.faild("رکورد وارد شده موجود است ");
            }

            var slug = comand.Slug.Slugify();
            var model = _reposetory.GetById(comand.Id);
            if (model==null)
            {
                return opretaion.faild("خطایی رخ داد دوباره تلاش کند");
            }
            model.Edited(comand.Title, comand.Discription, comand.Picture, comand.Alt, comand.ImageTitle,
                comand.Keywords, comand.MetaDiscription, slug);
            _reposetory.Save();
            return opretaion.Secusees();
        }

        public Edited fildinput(long id)
        {
            var model= _reposetory.GetById(id);
            return new Edited()
            {
                Title = model.Title,
                Discription = model.Discription,
                Picture = model.Picture,
                Alt = model.Alt,
                    ImageTitle = model.ImageTitle,
                    Keywords = model.Keywords,
                    MetaDiscription = model.MetaDiscription,
                    Slug = model.Slug,
                    Id = model.Id


            };
        }

        public List<ProductCategoryViewModel> All(SearchModel command)
        {
            return _reposetory.searches(command);
        }

        public List<ProductCategoryViewModel> full()
        {
            return _reposetory.myAll();
        }

        public List<ProductCategoryViewModel> allcategory()
        {
            return _reposetory.getcategory().ToList();
        }
    }
}
