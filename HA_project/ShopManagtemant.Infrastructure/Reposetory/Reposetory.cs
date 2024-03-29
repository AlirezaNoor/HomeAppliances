﻿using _0_Framework.Infrastructure;
using ShopManagemant.ApplicationContract.ProductCategory;
using ShopManagmant.Domin.ProductCategory;
using ShopManagtemant.Infrastructure.ShopContext;

namespace ShopManagtemant.Infrastructure.Reposetory
{
    public class Reposetory:GenericReposetory<long,ProductCategores>, IReposetory
    {
        private readonly MyContext _context;

        public Reposetory(MyContext context):base(context)
        {
            _context = context;
        }

      
        public List<ProductCategoryViewModel> searches(SearchModel model)
        {
            var qury = _context.Pgdbset.Select(x => new ProductCategoryViewModel()
            {
                Title = x.Title,
                Crationdate = x.datetime.ToString(),
                Picture = x.Picture,
                Id = x.Id
            });


            return qury.OrderByDescending(x=>x.Id).ToList();
        }



        public List<ProductCategoryViewModel> myAll()
        {
            return _context.Pgdbset.Select(x => new ProductCategoryViewModel()
            {
                Title = x.Title,
                Crationdate = x.datetime.ToString(),
                Picture = x.Picture,
                Id = x.Id
            }).ToList();
        }

        public List<ProductCategoryViewModel> getcategory()
        {
            return _context.Pgdbset.Select(x => new ProductCategoryViewModel
            {
                Title = x.Title,
                Id = x.Id
            }).ToList();
        }
    }
}
