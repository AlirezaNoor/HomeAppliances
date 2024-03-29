﻿using _0_Framework.Application;
using _0_Framework.Validation;
using ShopManagemant.ApplicationContract.Product;
using ShopManagmant.Domin.Product;

namespace ShopManagemant.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductReposetory _reposetory;

        public ProductApplication(IProductReposetory reposetory)
        {
            _reposetory = reposetory;
        }

        public OperationResult Create(Create command)
        {
            var operation = new OperationResult();
            if (_reposetory.Exist(x => x.Name == command.Name))
            {
                return operation.faild(ValidforApplication.doblicate);
            }

            var slug = command.slug.Slugify();
            var product = new Product(command.Name,command.Shortdiscription, command.Discription, command.code, command.Picture, command.PictureAlt, command.PictureTitle, slug, command.Keywords, command.Metadiscrption, command.CategoryId);
            _reposetory.Create(product);
          _reposetory.Save();
            return operation.Secusees();
        }

        public OperationResult Edit(EditProducts command)
        {
            var operation = new OperationResult();
            var product = _reposetory.GetById(command.id);
            if (product==null)
            {
                return operation.faild(ValidforApplication.mojodnist);
            }
            var slug = command.slug.Slugify();
            product.Edit(command.Name, command.Shortdiscription, command.Discription, command.code, command.Picture, command.PictureAlt, command.PictureTitle, slug, command.Keywords, command.Metadiscrption, command.CategoryId);
            _reposetory.Save();
            return operation.Secusees();
        }

        public EditProducts details(long id)
        {
            var product=_reposetory.GetById(id);
            return new EditProducts()
            {
                CategoryId = product.CategoryId,
                Discription = product.Discription,
                slug = product.slug,
                Shortdiscription = product.Shortdiscription,
                id = product.Id,
                Keywords = product.Keywords,
                Metadiscrption = product.Metadiscrption,
                Name = product.Name,
                Picture = product.Picture,
                PictureAlt = product.PictureAlt,
                PictureTitle = product.PictureTitle,

                code = product.code,
            };
        }

        public List<productviewmodel> search(SearchModel command)
        {
            return _reposetory.search(command);
        }


        public List<productviewmodel> All()
        {
            return _reposetory.GetAll();
        }

        public List<productviewmodel> getList()
        {
            return _reposetory.GetAll().Select(x => new productviewmodel() {id = x.id, Name = x.Name}).ToList();
        }
    }
}
