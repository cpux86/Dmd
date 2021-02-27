using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using Dmd.Infrastructure.Data;
using Dmd.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests.Repositories.ProductsRepository
{
    public class ProductRepositoryTest
    {
        [Fact]
        public async void Add()
        {
            CatalogContext context = new CatalogContext();
            
            Product product = new Product { Title = "Ноутбук Asus", Description = "Почти новый"};
            
            ProductRepositoryAsync repo = new ProductRepositoryAsync(context);
            await repo.AddAsync(product);

        }
    }
}
