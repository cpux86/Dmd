using Dmd.Infrastructure.Data;
using Dmd.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XUnitTests.Builder;

namespace IntegrationTest.Data
{
    public class CategoryRepositoryAsyncTest
    {
        [Fact]
        public async Task AddsCategorySetsId()
        {
            CatalogContext context = new CatalogContext();
            CategoryRepositoryAsync repo = new CategoryRepositoryAsync(context);
            var category = new CategoryBuilder().RootCategoryWidthAudit();
            await repo.AddAsync(category);
            
            Assert.True(category?.Id > 0);

            var cat = await repo.GetByIdAsync(category.Id);
            Assert.Equal(category, cat);
        }
    }
}
