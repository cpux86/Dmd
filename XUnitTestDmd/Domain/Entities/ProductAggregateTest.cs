using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using Dmd.Infrastructure.Business;
using Dmd.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTests.Builder;

namespace XUnitTests.Domain.Entities
{
    public class ProductAggregateTest
    {
        [Fact]
        public void AddProductToCategory()
        {
            var productTest = new ProductBuilder().Build();
            Category category = new Category();
            category.Products = new List<Product> { productTest };
            CategoryRepositoryAsync repo = new CategoryRepositoryAsync(new Dmd.Infrastructure.Data.CatalogContext());
            
        }
        
    }
}
