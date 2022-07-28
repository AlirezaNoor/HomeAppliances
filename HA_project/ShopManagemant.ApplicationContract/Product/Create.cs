namespace ShopManagemant.ApplicationContract.Product
{
    public class Create
    {
              public string Name { get; set; }
               public string Shortdiscription { get; set; }
               public string Discription { get; set; }
                public string code { get; set; }
                 public string Picture { get; set; }
               public string PictureAlt { get; set; }
              public string PictureTitle { get; set; }
               public string slug { get; set; }
             public string Keywords { get; set; }
            public string Metadiscrption { get; set; }
        public long CategoryId { get; set; }
    }
}
