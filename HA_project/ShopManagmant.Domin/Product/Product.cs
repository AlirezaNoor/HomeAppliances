using System.ComponentModel.DataAnnotations;
using _0_Framework;
using _0_Framework.Validation;
using ShopManagmant.Domin.ProductCategory;

namespace ShopManagmant.Domin.Product
{
    public class Product : Golbaldomin
    {

        public string Name { get; private set; }
        public string Shortdiscription { get; private set; }
        public string Discription { get; private set; }
        public string code { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string slug { get; private set; }
        public string Keywords { get; private set; }
        public string Metadiscrption { get; private set; }
        public long CategoryId { get; private set; }
        public ProductCategores categoryname { get; private set; }
        public List<ProductPicture.ProductPicture> ProductPictures { get; set; }
        public Product(List<ProductPicture.ProductPicture> productPictures)
        {
            ProductPictures = productPictures;
        }


        public Product(string name, string shortdiscription, string discription, string code, string picture, string pictureAlt, string pictureTitle, string slug, string keywords, string metadiscrption, long categoryId)
        {
            Name = name;

            Shortdiscription = shortdiscription;
            Discription = discription;
            this.code = code;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            this.slug = slug;
            Keywords = keywords;
            Metadiscrption = metadiscrption;
            CategoryId = categoryId;
       
        }

        public void Edit(string name,  string shortdiscription, string discription, string code, string picture, string pictureAlt, string pictureTitle, string slug, string keywords, string metadiscrption, long categoryId)
        {
            Name = name;
            Shortdiscription = shortdiscription;
            Discription = discription;
            this.code = code;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            this.slug = slug;
            Keywords = keywords;
            Metadiscrption = metadiscrption;
            CategoryId = categoryId;
        }

    }
}
