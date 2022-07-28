using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Domin.Inventory.InventoryAgg;
using Inventory.Infrastructure.Context;
using InventoryMangament.Applictioncontract.inventory;
using Microsoft.EntityFrameworkCore;
using ShopManagtemant.Infrastructure.ShopContext;

namespace Inventory.Infrastructure.Reposetory
{
    public class InventoryReposetory : GenericReposetory<long, Domin.Inventory.InventoryAgg.Inventory>, IInventoryReposetory
    {
        private readonly InventoryContext _inventoryContext;
        private readonly MyContext _ProducContext;

        public InventoryReposetory(InventoryContext inventoryContext, MyContext producContext) : base(inventoryContext)
        {
            _inventoryContext = inventoryContext;
            _ProducContext = producContext;
        }

        public List<InvertoryViewmodel> all()
        {
            var query= _inventoryContext.inventory.Select(x => new InvertoryViewmodel()
            {
                id = x.Id,
                ProductId = x.ProductId,
                Isinstack = x.IsStack,
                currentcount =x.CalculateCurentInventoryOperation(),
                price = x.unitprice
            }).ToList();
            var product = _ProducContext.prioduct.Select(x => new {id = x.Id, proname = x.Name}).ToList();

            var compeleted = query.ToList();
            compeleted.ForEach(x=>x.Productname=product.FirstOrDefault(y=>y.id==x.ProductId)?.proname);
            return compeleted;
        }

        public Domin.Inventory.InventoryAgg.Inventory Getbey(long productid)
        {
            return _inventoryContext.inventory.FirstOrDefault(x => x.Id == productid);
        }

        public List<LogOpertionviewmodel> getlog(long InventoryId)
        {
            var inventory = _inventoryContext.inventory.FirstOrDefault(x => x.Id == InventoryId);
            return inventory.inventoryOperation.Select(x => new LogOpertionviewmodel()
            {
                OerderId = x.OerderId,
                count = x.count,
                currentcount = x.currentcount,
                date = x.date.ToFarsi(),
                disciption = x.disciption,
                id = x.id,
                operation = x.operation,
                operationId = x.operationId,
                operationname = "مدیر سایت",
            }).ToList();
          
        }
    }
}
