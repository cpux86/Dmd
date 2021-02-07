using Application.Interfaces;
using Application.Interfaces.Repository;
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
    }
}
