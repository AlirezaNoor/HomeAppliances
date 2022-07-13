using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagemant.ApplicationContract.ProductPicture;

namespace ServiceHost.Areas.AdminiStrator.Models.ProductPictureModels
{
    public class ProductPictureModel
    {
        public List<ProductPictureViewModel>  productpicture { get; set; }
        public Create create { get; set; }
        public SelectList selectlist { get; set; }
        public Edited edited { get; set; }
    }
}
