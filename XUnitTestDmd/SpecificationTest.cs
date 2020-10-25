using Dmd.Domain.Core.Entities;
using Dmd.Domain.Core.Specification;
using Dmd.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestDmd
{
    public class SpecificationTest
    {
       [Fact]
        public void CategoryTest1()
        {
            CategoryFilterSpecification spcification = new CategoryFilterSpecification(1);
            EfRepository<Category> efRepository = new EfRepository<Category>();
            var result = efRepository.FirstOrDefaultAsync(spcification);
        }
    }
}
