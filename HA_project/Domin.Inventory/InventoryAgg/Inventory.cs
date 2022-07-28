using _0_Framework;

namespace Domin.Inventory.InventoryAgg;

public class Inventory:Golbaldomin
{
    public long ProductId { get; private set; }
    public decimal unitprice { get; private set; }
    public bool IsStack { get; private set; }
    public List<InventoryOperation> inventoryOperation { get; private set; }

    public Inventory(long productId, decimal unitprice)
    {
        ProductId = productId;
        this.unitprice = unitprice;
        IsStack = false;
            
    }
    public void Edited(long productId, decimal unitprice)
    {
        ProductId = productId;
        this.unitprice = unitprice;
        IsStack = false;

    }


    protected Inventory()
    {
    }

    public long CalculateCurentInventoryOperation()
    {
        var Addproduct = inventoryOperation.Where(x => x.operation).Sum(x => x.count);
        var removeproduct = inventoryOperation.Where(x => !x.operation).Sum(x => x.count);
        return Addproduct - removeproduct;

    }

    public void AddToInventoryOperation(long count,long opertaionid,string discription)
    {
        var ourcurrentcount = CalculateCurentInventoryOperation() + count;
        var Inventryoperatrionforadd =
            new InventoryOperation(true,count,ourcurrentcount,opertaionid,0,Id,discription);
        inventoryOperation.Add(Inventryoperatrionforadd);
        if (ourcurrentcount>0)
        {
            IsStack = true;
        }
        else
        {
            IsStack = false;
        }
    }

    public void RemoveToInventoryOperation(long count, long opertaionid, string discription,long orederId)
    {
        var ourcurrentcount = CalculateCurentInventoryOperation()-count;
        var Inventryoperatrionforremove =
            new InventoryOperation(false, count, ourcurrentcount, opertaionid, orederId, Id, discription);
             
        inventoryOperation.Add(Inventryoperatrionforremove);
        if (ourcurrentcount > 0)
        {
            IsStack = true;
        }
        else
        {
            IsStack = false;
        }
    }
}