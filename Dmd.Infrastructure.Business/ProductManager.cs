using Application.DTO.Product;
using Application.Interfaces;
using Application.Interfaces.Repository;
using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Infrastructure.Business
{
    public class ProductManager : IProductManager
    {
        private readonly IProductRepositoryAsync _productRepository;

        public ProductManager(IProductRepositoryAsync productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Property> AllProperties(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(ProductDTO productDTO)
        {
            Product product = new Product();
            product.Title = productDTO.Title;
            product.Description = productDTO.Description;
            var i = productDTO.Properties;

            var x = productDTO.CategoryId;


            // если все нормально, сохраняем продукт в БД
            _productRepository.AddAsync(product);
            throw new NotImplementedException();
        }
    }
}
