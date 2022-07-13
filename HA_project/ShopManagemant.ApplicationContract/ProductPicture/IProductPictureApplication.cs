using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace ShopManagemant.ApplicationContract.ProductPicture
{
    public interface IProductPictureApplication
    {
        OperationResult Create(Create command);
        OperationResult Edit(Edited command);
        Edited fildTheblunk(long id);
        List<ProductPictureViewModel> GetAllpic();
        OperationResult Remove(long id);
        OperationResult Restore(long id);

    }
}
