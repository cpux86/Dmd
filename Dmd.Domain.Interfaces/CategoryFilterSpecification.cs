using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ardalis.Specification;
using Dmd.Domain.Entities;

namespace Dmd.Domain.Specification
{
    public sealed class CategoryFilterSpecification : Specification<Category>
    {
        public CategoryFilterSpecification(int id)
        {
            Query.Where(c => c.Id == id);
        }
    }
}
