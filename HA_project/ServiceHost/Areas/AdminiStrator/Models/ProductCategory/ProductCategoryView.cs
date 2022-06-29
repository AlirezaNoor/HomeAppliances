using ShopManagemant.ApplicationContract.ProductCategory;

namespace ServiceHost.Areas.AdminiStrator.Models.ProductCategory
{
    public class ProductCategoryView
    {
        public List<ProductCategoryViewModel> ProductCategory { get; set; }
        public SearchModel Search { get; set; }
        public Create create { get; set; }
        public Edited Edited { get; set; }
    }
}
