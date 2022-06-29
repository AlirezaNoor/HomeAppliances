using _0_Framework.GenericReposetory;
using ShopManagemant.ApplicationContract.ProductCategory;

namespace ShopManagmant.Domin.ProductCategory
{
    public interface IReposetory: IGenericReposetory<long,ProductCategores>
    {
        List<ProductCategoryViewModel> searches(SearchModel model);
    }
}
