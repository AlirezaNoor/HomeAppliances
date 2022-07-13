using _0_Framework.GenericReposetory;
using ShopManagemant.ApplicationContract.ProductPicture;

namespace ShopManagmant.Domin.ProductPictureAgg
{
    public interface IProductPicture:IGenericReposetory<long, ProductPicture.ProductPicture>
    {
        List<ProductPictureViewModel> getAll();
    }
}
