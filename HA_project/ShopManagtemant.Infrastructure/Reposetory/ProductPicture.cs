using System.Globalization;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagemant.ApplicationContract.ProductPicture;
using ShopManagmant.Domin.ProductPictureAgg;
using ShopManagtemant.Infrastructure.ShopContext;

namespace ShopManagtemant.Infrastructure.Reposetory
{
    public class ProductPicture: GenericReposetory<long,ShopManagmant.Domin.ProductPicture.ProductPicture>, IProductPicture
    {
        private readonly MyContext _context;

        public ProductPicture(MyContext context):base(context)
        {
            _context = context;
        }

        public List<ProductPictureViewModel> getAll()
        {
            return _context.productpicture.Include(x=>x.product).Select(x=>new ProductPictureViewModel()
            {
                id = x.Id,
                createdate = x.datetime.ToString(CultureInfo.InvariantCulture),
                picture = x.Picture,
                product = x.product.Name,
                Instock = x.IsRemoved
            }).ToList();
        }
    }
}
