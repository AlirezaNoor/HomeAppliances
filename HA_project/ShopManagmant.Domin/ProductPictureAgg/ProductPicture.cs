using _0_Framework;

namespace ShopManagmant.Domin.ProductPicture
{
    public class ProductPicture :Golbaldomin
    {
        public long ProductId { get; private set; }
        public String Picture { get; private set; }
        public String PictureTitle { get; private set; }
        public String PictureAlt { get; private set; }
        public bool IsRemoved { get; private set; }
        public Product.Product product { get; set; }

        public ProductPicture(long productId, string picture, string pictureTitle, string pictureAlt)
        {
            ProductId = productId;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            IsRemoved = false;
        }

        public void Edited(long productId, string picture, string pictureTitle, string pictureAlt)
        {
            ProductId = productId;
            Picture = picture;
            PictureTitle = pictureTitle;
            PictureAlt = pictureAlt;
            IsRemoved = false;
        }


        public void Remove()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
    
}
