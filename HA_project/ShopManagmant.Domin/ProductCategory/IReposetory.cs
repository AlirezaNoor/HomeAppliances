using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ShopManagemant.ApplicationContract.ProductCategory;

namespace ShopManagmant.Domin.ProductCategory
{
    public interface IReposetory
    {
        void Create(ProductCategores entity);
        ProductCategores GetById(long id);
        bool Exist(Expression<Func<ProductCategores,bool>>expression);
        List<ProductCategores> GetAll();
        List<ProductCategoryViewModel> searches(SearchModel model);
        void Save();
    }
}
