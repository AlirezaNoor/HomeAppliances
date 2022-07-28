namespace InventoryMangament.Applictioncontract.inventory
{
    public class InvertoryViewmodel
    {
        public long id { get; set; }
        public string Productname { get; set; }
        public decimal price { get; set; }
        public long currentcount { get; set; }
        public long ProductId { get; set; }
        public bool Isinstack { get; set; }
    }
}
