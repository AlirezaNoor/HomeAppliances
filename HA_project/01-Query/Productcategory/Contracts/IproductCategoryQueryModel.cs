using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Query.Productcategory.Contracts.ProductWithProductcategory;

namespace _01_Query.Productcategory.Contracts
{
    public interface IproductCategoryQueryModel
    {
        List<ProductCategoryQueryModels> GetAll();
        List<ProductCategoryQueryModels> getList();
        List<ProductCategoryQueryModels> GetAllBy(string Slug);

    }
}
