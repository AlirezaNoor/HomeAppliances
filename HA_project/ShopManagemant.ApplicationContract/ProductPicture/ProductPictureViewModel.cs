namespace ShopManagemant.ApplicationContract.ProductPicture
{
    public class ProductPictureViewModel
    {
        public long id { get; set; }
        public string picture { get; set; }
        public string product { get; set; }

        public string createdate { get; set; }
        public bool Instock { get; set; }
    }
}
