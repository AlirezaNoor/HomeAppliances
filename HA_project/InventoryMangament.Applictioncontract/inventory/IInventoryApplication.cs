using _0_Framework.Application;

namespace InventoryMangament.Applictioncontract.inventory
{
    public  interface IInventoryApplication
    {
        OperationResult Create(createInventory comnmand);
        OperationResult Edite(Edited command);
        OperationResult Addtoinventory(AddToIvertory comand);
        OperationResult Deleteinventory(List<RemoveFromInvzenroty> command);
        OperationResult Deleteinventory(RemoveFromInvzenroty command);

        Edited Getdtials(long id);
        List<InvertoryViewmodel> all();
        List<LogOpertionviewmodel> getlog(long inventoryid);
    }
}
