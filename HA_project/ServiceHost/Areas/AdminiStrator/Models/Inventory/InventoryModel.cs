using InventoryMangament.Applictioncontract.inventory;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.AdminiStrator.Models.Inventory
{
    public class InventoryModel
    {
        public createInventory create { get; set; }
        public List<InvertoryViewmodel> inventoryview { get; set; }
        public SelectList SelectList { get; set; }
        public Edited edited{ get; set; }

    }
}
