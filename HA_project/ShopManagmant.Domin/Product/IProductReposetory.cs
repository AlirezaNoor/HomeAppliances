using _0_Framework.GenericReposetory;
using ShopManagemant.ApplicationContract.Product;

namespace ShopManagmant.Domin.Product
{
    public interface IProductReposetory:IGenericReposetory<long,Product>
    {
        List<productviewmodel> search(SearchModel model);
    }
}
