namespace InventoryMangament.Applictioncontract.inventory
{
    public class LogOpertionviewmodel
    {

        public long id { get;  set; }
        public bool operation { get; set; }
        public long count { get; set; }
        public long currentcount { get; set; }
        public long operationId { get; set; }
        public string operationname { get; set; }
        public long OerderId { get; set; }
        public string disciption { get; set; }
        public string date { get; set; }
    }
}
