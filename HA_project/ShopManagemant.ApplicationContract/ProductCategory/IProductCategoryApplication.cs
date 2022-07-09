using _0_Framework.Application;

namespace ShopManagemant.ApplicationContract.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResult Create(Create command);
        OperationResult Edited(Edited comand);
        Edited fildinput(long id);
        List<ProductCategoryViewModel> All(SearchModel command);
        List<ProductCategoryViewModel> full();
        List<ProductCategoryViewModel> allcategory();

    }
}
