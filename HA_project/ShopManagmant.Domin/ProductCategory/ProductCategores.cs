using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework;
using _0_Framework.Validation;

namespace ShopManagmant.Domin.ProductCategory
{
    public class ProductCategores:Golbaldomin
    {
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        
        public string Title { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Discription { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Picture { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Alt { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string ImageTitle { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Keywords { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string MetaDiscription { get; private set; }
        [Required(ErrorMessage = ValidationforDomian.validatation)]
        public string Slug { get; private set; }

        public ProductCategores(string title, string discription, string picture, string alt, string imageTitle, string keywords, string metaDiscription, string slug)
        {
            Title = title;
            this.Discription = discription;
            Picture = picture;
            Alt = alt;
            ImageTitle = imageTitle;
            Keywords = keywords;
            MetaDiscription = metaDiscription;
            Slug = slug;
        }

       public void Edited(string title, string discription, string picture, string alt, string imageTitle, string keywords, string metaDiscription, string slug)
        {
            Title = title;
            this.Discription = discription;
            Picture = picture;
            Alt = alt;
            ImageTitle = imageTitle;
            Keywords = keywords;
            MetaDiscription = metaDiscription;
            Slug = slug;
        }
    }

}
