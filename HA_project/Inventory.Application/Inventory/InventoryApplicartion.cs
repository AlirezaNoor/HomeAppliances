using _0_Framework.Application;
using Domin.Inventory.InventoryAgg;
using InventoryMangament.Applictioncontract.inventory;

namespace Inventory.Application.Inventory
{
    public class InventoryApplicartion : IInventoryApplication
    {
        private readonly IInventoryReposetory _reposetory;

        public InventoryApplicartion(IInventoryReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult Create(createInventory comnmand)
        {
            var operation = new OperationResult();
            var inventory = new Domin.Inventory.InventoryAgg.Inventory(comnmand.ProductId, comnmand.unitprice);
            _reposetory.Create(inventory);
            _reposetory.Save();
            return operation.Secusees();
        }

        public OperationResult Edite(Edited command)
        {
            var operation = new OperationResult();
            var result = _reposetory.GetById(command.Id);
            result.Edited(command.ProductId, command.unitprice);
            _reposetory.Save();
            return operation.Secusees();
        }

        public OperationResult Addtoinventory(AddToIvertory comand)
        {
            var operation = new OperationResult();
            var result = _reposetory.GetById(comand.Inevetoryid);
            const long opertionid = 1;
            result.AddToInventoryOperation(comand.count, opertionid, comand.Discription);
            _reposetory.Save();
            return operation.Secusees();
        }

        public OperationResult Deleteinventory(List<RemoveFromInvzenroty> command)
        {
            var operation = new OperationResult();
            foreach (var item in command)
            {
                var result = _reposetory.Getbey(item.Productid);
                result.RemoveToInventoryOperation(item.count, 0, item.Discription, item.oerderId);
               
            }
            _reposetory.Save();
            return operation.Secusees();
        }

        public OperationResult Deleteinventory(RemoveFromInvzenroty command)
        {
            var operation = new OperationResult();
            var result = _reposetory.GetById(command.Inevetoryid);
            const long opertionid = 1;
            result.RemoveToInventoryOperation(command.count, opertionid, command.Discription, 0);
            _reposetory.Save();
            return operation.Secusees();
        }

        public Edited Getdtials(long id)
        {
            var result = _reposetory.GetById(id);
            return new Edited()
            {
                Id = result.Id,
                ProductId = result.ProductId,
                unitprice = result.unitprice
            };
        }

        public List<InvertoryViewmodel> all()
        {

            return _reposetory.all().ToList();
        }

        public List<LogOpertionviewmodel> getlog(long inventoryid)
        {
            return _reposetory.getlog(inventoryid);
        }
    }
}
