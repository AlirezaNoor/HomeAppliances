using _01_Query.Productcategory.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Components
{
    public class ProductCategoryComponent:ViewComponent
    {
        private readonly IproductCategoryQueryModel _query;

        public ProductCategoryComponent(IproductCategoryQueryModel query)
        {
            _query = query;
        }

        public IViewComponentResult Invoke()
        {
            var category = _query.GetAll();
            return View(category);
        }
    }
}
