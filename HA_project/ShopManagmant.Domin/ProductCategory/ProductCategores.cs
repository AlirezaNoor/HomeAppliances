using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework;

namespace ShopManagmant.Domin.ProductCategory
{
    public class ProductCategores:Golbaldomin
    {
        public string Title { get; private set; }
        public string Discription { get; private set; }
        public string Picture { get; private set; }
        public string Alt { get; private set; }
        public string ImageTitle { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDiscription { get; private set; }
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
