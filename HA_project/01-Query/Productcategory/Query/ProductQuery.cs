using _01_Query.Productcategory.Contracts.ProductWithProductcategory;
using DiscountManegmant.Infrastructure.context;
using Inventory.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ShopManagtemant.Infrastructure.ShopContext;

namespace _01_Query.Productcategory.Query
{
    public class ProductQuery: IProductQuery
    {
        private readonly MyContext _context;
        private readonly  CustomerDiscountContext _discountContext;
        private  readonly  InventoryContext _inventoryContext;

        public ProductQuery(InventoryContext inventoryContext, CustomerDiscountContext discountContext, MyContext context)
        {
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
            _context = context;
        }

        public List<ProductwithCategoryViewmodel> getAll()
        {
            var getAllproduct = _context.prioduct.Include(x=>x.categoryname).ToList();
            var inventory = _inventoryContext.inventory.Select(x => new {x.IsStack, x.ProductId, x.unitprice}).ToList();
            var discount = _discountContext.Customer.Select(x => new {x.productId, x.DiscountRate}).ToList();
         var qury=   getAllproduct.Select(x => new ProductwithCategoryViewmodel()
            {
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTilte = x.PictureTitle,
                Slug = x.slug,
                title = x.Name,
                id = x.Id,
                categry = x.categoryname.Title,

            }).ToList();

         foreach (var item in qury)
         {
             item.price = inventory.FirstOrDefault(x => x.ProductId == item.id)?.unitprice.ToString();
             var discounrate = discount.FirstOrDefault(x => x.productId == item.id)?.DiscountRate;
             if (discounrate!=null)
             {
                 var getprice = inventory.FirstOrDefault(x => x.ProductId == item.id).unitprice;

                    var ouroff = 100 - discounrate;
                    var pricetoint = Convert.ToInt32(getprice);
                 var result = (pricetoint * ouroff) / 100;
                 item.priceWitheDisCount = result.ToString();
                 item.IsDiscounted = true;
                 item.Rate = discount.FirstOrDefault(x => x.productId == item.id).DiscountRate;
               
             }
             else
             {
                 item.IsDiscounted = false;
             }

             
         }

         return qury;

        }
    }
}
