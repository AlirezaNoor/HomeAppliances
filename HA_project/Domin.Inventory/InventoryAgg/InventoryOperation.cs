namespace Domin.Inventory.InventoryAgg;

public class InventoryOperation
{

    public long id { get; private set; }
    public bool operation { get; private set; }
    public long count { get; private set; }
    public long currentcount { get; private set; }
    public long operationId { get; private set; }
    public long OerderId { get; set; }
    public long InventoryId { get; private set; }
    public string disciption  { get; private set; }
    public DateTime date { get; private set; }
    public Inventory Inventory{ get; private set; }

    public InventoryOperation(bool operation, long count, long currentcount, long operationId, long oerderId, long inventoryId, string disciption)
    {
        this.operation = operation;
        this.count = count;
        this.currentcount = currentcount;
        this.operationId = operationId;
        OerderId = oerderId;
        InventoryId = inventoryId;
        this.disciption = disciption;
        date=DateTime.Now;
    }
}