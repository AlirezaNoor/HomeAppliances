using System.Linq.Expressions;
using ShopManagemant.ApplicationContract.ProductCategory;
using ShopManagmant.Domin.ProductCategory;
using ShopManagtemant.Infrastructure.ShopContext;

namespace ShopManagtemant.Infrastructure
{
    public class Reposetory: IReposetory
    {
        private readonly MyContext _context;

        public Reposetory(MyContext context)
        {
            _context = context;
        }

        public void Create(ProductCategores entity)
        {
            _context.Pgdbset.Add(entity);
            Save();
        }

        public ProductCategores GetById(long id)
        {
            return _context.Pgdbset.FirstOrDefault(x => x.Id == id);
        }

        public bool Exist(Expression<Func<ProductCategores, bool>> expression)
        {
            return _context.Pgdbset.Any(expression);
        }

        public List<ProductCategores> GetAll()
        {
            return _context.Pgdbset.ToList();
        }

        public List<ProductCategoryViewModel> searches(SearchModel model)
        {
            var qury = _context.Pgdbset.Select(x => new ProductCategoryViewModel()
            {
                Title = x.Title,
                Crationdate = x.datetime.ToString(),
                Discription = x.Discription,
                Picture = x.Picture,
                Id = x.Id
            });
            if (!string.IsNullOrWhiteSpace(model.Title))
            {
                return qury.Where(x => x.Title.Contains(model.Title)).ToList();
            }

            return qury.OrderByDescending(x=>x.Id).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
