using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ardalis.Specification;
using Dmd.Domain.Core.Entities;

namespace Dmd.Domain.Core.Specification
{
    public sealed class CategoryFilterSpecification : Specification<Category>
    {
        public CategoryFilterSpecification(int id)
        {
            Query.Where(c => c.Title == "kfdkf");
        }
    }
}
