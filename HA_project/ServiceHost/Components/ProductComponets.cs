using _01_Query.Productcategory.Contracts.ProductWithProductcategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Components
{
    public class ProductComponets:ViewComponent
    {
        private readonly IProductQuery _query;

        public ProductComponets(IProductQuery query)
        {
            _query = query;
        }

        public IViewComponentResult Invoke()
        {
            var test = _query.getAll().OrderByDescending(x=>x.id).Take(5).ToList();
            return View(test);
        }
    }
}
