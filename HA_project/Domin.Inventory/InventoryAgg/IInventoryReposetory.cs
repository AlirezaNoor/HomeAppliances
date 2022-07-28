using _0_Framework.GenericReposetory;
using InventoryMangament.Applictioncontract.inventory;

namespace Domin.Inventory.InventoryAgg
{
    public interface IInventoryReposetory:IGenericReposetory<long,Inventory>
    {
        List<InvertoryViewmodel> all();
        Inventory Getbey(long productid);
        List<LogOpertionviewmodel> getlog(long InventoryId);
    }
}
