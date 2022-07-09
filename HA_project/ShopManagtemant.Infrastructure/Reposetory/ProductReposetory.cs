using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagemant.ApplicationContract.Product;
using ShopManagmant.Domin.Product;
using ShopManagtemant.Infrastructure.ShopContext;

namespace ShopManagtemant.Infrastructure.Reposetory
{
    public class ProductReposetory : GenericReposetory<long, Product>, IProductReposetory
    {
        private readonly MyContext _context;

        public ProductReposetory(MyContext context) :base(context)
        {
            _context = context;
        }

        public List<productviewmodel> search(SearchModel model)
        {
            var query = _context.prioduct.Include(x => x.categoryname).Select(x => new productviewmodel()
            {
                Name = x.Name,
                UnitPrice = x.UnitPrice,
                category = x.categoryname.Title,
                categoryid = x.CategoryId,
                code = x.code,
                id = x.Id,
                picture = x.Picture,
                IsInStock = x.IsInStock
            });
            // if (!string.IsNullOrWhiteSpace(model.name))
            // {
            //     query = query.Where(x => x.Name.Contains(model.name));
            // }
            // if (!string.IsNullOrWhiteSpace(model.code))
            // {
            //     query = query.Where(x => x.code.Contains(model.code));
            // }
            // if (model.categoryid!=0)
            // {
            //     query = query.Where(x => x.id == model.categoryid);
            // }

            return query.OrderByDescending(x=>x.id).ToList();
        }
    }
}
