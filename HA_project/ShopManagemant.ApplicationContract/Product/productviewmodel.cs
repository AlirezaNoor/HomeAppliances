namespace ShopManagemant.ApplicationContract.Product;

public class productviewmodel 
{
    public long id { get; set; }
    public string Name { get; set; }
    public string code { get; set; }
    public string category { get; set; }
    public long categoryid { get; set; }
    public string picture { get; set; }
    public double UnitPrice { get; set; }
    public  bool IsInStock { get; set; }
}