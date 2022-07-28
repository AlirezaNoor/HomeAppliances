using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Query.Productcategory.Contracts.ProductWithProductcategory
{
    public class ProductwithCategoryViewmodel
    {
        public long id  { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTilte { get; set; }
        public string price { get; set; }
        public string priceWitheDisCount { get; set; }
        public string title { get; set; }
        public string  categry{ get; set; }
        public string  Slug { get; set; }
        public int Rate { get; set; }
        public bool IsDiscounted { get; set; }
        public string Strat { get; set; }
        public string End { get; set; }



    }
}
