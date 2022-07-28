using System.ComponentModel.DataAnnotations;
using _0_Framework.Validation;
using _01_Query.Productcategory.Contracts.ProductWithProductcategory;

namespace _01_Query.Productcategory.Contracts
{
    public class ProductCategoryQueryModels
    {
        public long  id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string Alt { get; set; }
        public string ImageTitle { get; set; }
        public string Slug { get; set; }
        public string Keywords { get;  set; }
        public string MetaDiscription { get;  set; }

        public List<ProductwithCategoryViewmodel> products { get; set; }
 
    }

}
