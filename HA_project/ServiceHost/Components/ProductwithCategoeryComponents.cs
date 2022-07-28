using _01_Query.Productcategory.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Components
{
    public class ProductwithCategoeryComponents:ViewComponent
    {
        private readonly IproductCategoryQueryModel _category;

        public ProductwithCategoeryComponents(IproductCategoryQueryModel category)
        {
            _category = category;
        }

        public IViewComponentResult Invoke()
        {
            var item = _category.getList();

            return View(item);
        }
    }
}
