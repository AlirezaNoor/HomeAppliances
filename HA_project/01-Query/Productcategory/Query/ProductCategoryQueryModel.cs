using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Query.Productcategory.Contracts;
using _01_Query.Productcategory.Contracts.ProductWithProductcategory;
using DiscountManegmant.Infrastructure.context;
using Inventory.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ShopManagmant.Domin.Product;
using ShopManagtemant.Infrastructure.ShopContext;

namespace _01_Query.Productcategory.Query
{
    public class ProductCategoryQueryModel:IproductCategoryQueryModel
    {
        private readonly MyContext _conext;
        private readonly InventoryContext _inventory;
        private readonly CustomerDiscountContext _customerDiscount;

        public ProductCategoryQueryModel(MyContext conext, InventoryContext inventory, CustomerDiscountContext customerDiscount)
        {
            _conext = conext;
            _inventory = inventory;
            _customerDiscount = customerDiscount;
        }

        public List<Contracts.ProductCategoryQueryModels> GetAll()
        {
            return _conext.Pgdbset.Select(x => new Contracts.ProductCategoryQueryModels
            {
                id = x.Id,
                Title = x.Title,
                Alt = x.Alt,
                ImageTitle = x.ImageTitle,
                Picture = x.Picture,
                Slug = x.Slug
            }).ToList();
        }

        public List<Contracts.ProductCategoryQueryModels> getList()
        {
            var inventory = _inventory.inventory.Select(x => new {x.ProductId, x.unitprice}).ToList();
            var discount = _customerDiscount.Customer
                .Select(x => new {x.productId, x.StartDiscount, x.EndDiscount, x.DiscountRate}).ToList();
            var item = _conext.Pgdbset.Include(x => x.product).ThenInclude(x => x.categoryname).Select(x =>
                new ProductCategoryQueryModels()
                {
                    id = x.Id,
                    Title = x.Title,
                    products = MapProduct(x.product),
                    
                    

                }).ToList();
            foreach (var my in item)
            {
                foreach (var pro in my.products)
                {
                    pro.price = inventory.FirstOrDefault(x => x.ProductId == pro.id)?.unitprice.ToString();
                    var darsad = discount.FirstOrDefault(x => x.productId == pro.id)?.DiscountRate;
                    if (darsad!=null)
                    {
                        var result = (100 - darsad);
                        var priceint = inventory.FirstOrDefault(x => x.ProductId == pro.id)?.unitprice;
                        var test = (priceint * result) / 100;
                        pro.priceWitheDisCount = test.ToString();
                        pro.IsDiscounted = true;
                        pro.Rate = discount.FirstOrDefault(x => x.productId == pro.id).DiscountRate;
                    }
                    else
                    {
                        pro.IsDiscounted = false;
                    }

                }
            }
            return item;
        }

        public List<ProductCategoryQueryModels> GetAllBy(string Slug)
        {
            var category = _conext.Pgdbset.Include(x => x.product).Select(x => new ProductCategoryQueryModels()
            {
                Title = x.Title,
                Alt = x.Alt,
                ImageTitle = x.ImageTitle,
                Keywords = x.Keywords,
                MetaDiscription = x.MetaDiscription,
                Picture = x.Picture,
                Slug = x.Slug,
                id = x.Id,
                products = MapProduct(x.product)

            }).FirstOrDefault(x => x.Slug == Slug);
            var inventory = _inventory.inventory.Select(x => new { x.ProductId, x.unitprice }).ToList();
            var discount = _customerDiscount.Customer
                .Select(x => new { x.productId, x.StartDiscount, x.EndDiscount, x.DiscountRate }).ToList();

            foreach (var x in category.products)
            {
                x.price = inventory.FirstOrDefault(y => y.ProductId == x.id).unitprice.ToString();
                var off = discount.FirstOrDefault(z => z.productId == x.id)?.DiscountRate;
                if (off != null)
                {
                    var offresult = 100 - Convert.ToInt32(off);
                    var oldprice = Convert.ToInt32(x.price);
                    var dis = (oldprice * offresult) / 100;
                    x.priceWitheDisCount = dis.ToString();
                    x.Strat = discount.FirstOrDefault(r => r.productId == x.id).StartDiscount.ToString();
                    x.End = discount.FirstOrDefault(r => r.productId == x.id).EndDiscount.ToString();
                    x.Rate= discount.FirstOrDefault(r => r.productId == x.id).DiscountRate;
                    x.IsDiscounted = true;
                }
                else
                {
                    x.IsDiscounted = false;
                }
            }

        }

        private static List<ProductwithCategoryViewmodel> MapProduct(List<Product> Product)
        {

            var result = new List<ProductwithCategoryViewmodel>();
            foreach (var pro in Product)
            {
                var item = new ProductwithCategoryViewmodel
                {
                    Picture = pro.Picture,
                    PictureTilte = pro.PictureTitle,
                    PictureAlt = pro.PictureAlt,
                    Slug = pro.slug,
                    id = pro.Id,
                    title = pro.Name,
                    categry = pro.categoryname.Title,
                    
                };
                result.Add(item);
            }

            return result;

        }
    }
}
