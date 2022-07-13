using System.ComponentModel.DataAnnotations;
using _0_Framework;
using _0_Framework.Validation;
using ShopManagmant.Domin.ProductCategory;

namespace ShopManagmant.Domin.Product
{
    public class Product : Golbaldomin
    {
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Name { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public double UnitPrice { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Shortdiscription { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string  Discription { get; private set; }
        public bool IsInStock { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string code { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Picture { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string PictureAlt { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string PictureTitle { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string slug { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Keywords { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Metadiscrption { get; private set; }
        public long CategoryId { get; private set; }
        public ProductCategores  categoryname { get; private set; }

        public List<ProductPicture.ProductPicture> ProductPictures { get; set; }

        public Product(List<ProductPicture.ProductPicture> productPictures)
        {
            ProductPictures = productPictures;
        }


        public Product(string name, double unitPrice, string shortdiscription, string discription, string code, string picture, string pictureAlt, string pictureTitle, string slug, string keywords, string metadiscrption, long categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
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
            IsInStock = true;
        }

        public void Edit(string name, double unitPrice, string shortdiscription, string discription, string code, string picture, string pictureAlt, string pictureTitle, string slug, string keywords, string metadiscrption, long categoryId)
        {
            Name = name;
            UnitPrice = unitPrice;
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
            IsInStock = true;
        }
        public void InStock()
        {
            IsInStock = true;
        }

        public void NotInStock()
        {
            IsInStock = false;
        }
    }
}
