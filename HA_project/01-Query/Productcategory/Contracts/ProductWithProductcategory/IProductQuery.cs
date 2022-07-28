using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Query.Productcategory.Contracts.ProductWithProductcategory
{
    public  interface IProductQuery
    {
        List<ProductwithCategoryViewmodel> getAll();
    }
}
