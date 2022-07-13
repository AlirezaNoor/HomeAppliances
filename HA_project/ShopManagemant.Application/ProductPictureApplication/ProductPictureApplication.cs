using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagemant.ApplicationContract.ProductPicture;
using ShopManagmant.Domin.ProductPicture;
using ShopManagmant.Domin.ProductPictureAgg;

namespace ShopManagemant.Application.ProductPictureApplication
{
    public class ProductPictureApplication: IProductPictureApplication
    {
        private readonly IProductPicture _productPicture;

        public ProductPictureApplication(IProductPicture productPicture)
        {
            _productPicture = productPicture;
        }

        public OperationResult Create(Create command)
        {
            var Operation = new OperationResult();
            if (_productPicture.Exist(x=>x.Picture==command.Picture))
            {
                Operation.faild();
            }

            var ProductPicture = new ProductPicture(command.ProductId, command.Picture, command.PictureTitle,
                command.PictureAlt);

            _productPicture.Create(ProductPicture);
            _productPicture.Save();
            return Operation.Secusees();
        }

        public OperationResult Edit(Edited command)
        {
            var Operation = new OperationResult();
            if (_productPicture.Exist(x=>x.Picture==command.Picture&&x.Id!=command.id))
            {
                Operation.faild();

            }

          var productpictur=  _productPicture.GetById(command.id);
          productpictur.Edited(command.ProductId,command.Picture,command.PictureTitle,command.PictureAlt);
          _productPicture.Save();
          return Operation.Secusees();
        }

        public Edited fildTheblunk(long id)
        {
            var pro = _productPicture.GetById(id);
            return new Edited()
            {
                id = pro.Id,
                Picture = pro.Picture,
                PictureAlt = pro.PictureAlt,
                PictureTitle = pro.PictureTitle,
                ProductId = pro.ProductId
                
            };
        }

        public List<ProductPictureViewModel> GetAllpic()
        {
            return _productPicture.getAll();
        }

        public OperationResult Remove(long id)
        {
            var Operation = new OperationResult();
            if (id==null)
            {
                Operation.faild();
            }

            var Pro=_productPicture.GetById(id);
            Pro.Remove();
            _productPicture.Save();
            return Operation.Secusees();
        }

        public OperationResult Restore(long id)
        {
            var Operation = new OperationResult();
            if (id == null)
            {
                Operation.faild();
            }

            var Pro = _productPicture.GetById(id);
            Pro.Restore();
            _productPicture.Save();
            return Operation.Secusees();
        }
    }
}
