using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using ShopManagemant.ApplicationContract.Product;

namespace ServiceHost.Areas.AdminiStrator.Models.Product
{
    public class ProductModels
    {
        public List<productviewmodel>  productviewmodel { get; set; }
        public Create create { get; set; }
        public SearchModel Search { get; set; }
        public SelectList Select { get; set; }
        public EditProducts edit { get; set; }
    }
}
