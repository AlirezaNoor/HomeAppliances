using InventoryMangament.Applictioncontract.inventory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.AdminiStrator.Models;
using ServiceHost.Areas.AdminiStrator.Models.Inventory;
using ShopManagemant.ApplicationContract.Product;

namespace ServiceHost.Areas.AdminiStrator.Controllers.Inventory
{
    [Area("AdminiStrator")]
    public class InventoryController : Controller
    {
        private readonly IInventoryApplication _inventory;
        private readonly IProductApplication _product;

        public InventoryController(IProductApplication product, IInventoryApplication inventory)
        {
            _product = product;
            _inventory = inventory;
        }

        public IActionResult Index()
        {
            var model = new InventoryModel();
            model.inventoryview = _inventory.all();
            return View(model);
        }

        public IActionResult sendTodatabase()
        {
            var model = new InventoryModel();
            model.SelectList = new SelectList(_product.getList(), "id", "Name");
            return View(model);
        }
        [HttpPost]
        public IActionResult sendTodatabase(InventoryModel command)
        {
            _inventory.Create(command.create);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _inventory.all()) });

        }

        public IActionResult Editeds(long id)
        {
            var model = new InventoryModel();
            model.edited = _inventory.Getdtials(id);
            model.SelectList = new SelectList(_product.getList(),"id","Name",model.edited.ProductId);

            return View(model);
        }
        [HttpPost]
        public IActionResult Editeds(InventoryModel command )
        {
            _inventory.Edite(command.edited);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _inventory.all()) });

        }

        public IActionResult Addtoinventory(long id)
        {
            var model = new AddToIvertory()
            {
                Inevetoryid = id,
            };
            

            return View(model);
        }
        [HttpPost]
        public IActionResult Addtoinventory(AddToIvertory command)
        {
            _inventory.Addtoinventory(command);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _inventory.all()) });


        }
        

        public IActionResult Deletfrominventory(long id)
        {
            var model = new RemoveFromInvzenroty()
            {
                Inevetoryid = id,
            };
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Deletfrominventory(RemoveFromInvzenroty command)
        {
            _inventory.Deleteinventory(command);
            return Json(new { isValid = true, html = Helper.Helper.RenderRazorViewToString(this, "my", _inventory.all()) });


        }

        public IActionResult Log(long id)
        {
            var model = _inventory.getlog(id).ToList();
            return View(model);
        }

    }
}
