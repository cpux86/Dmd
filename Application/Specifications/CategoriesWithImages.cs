using System;
using System.Collections.Generic;
using System.Text;
using Ardalis.Specification;
using Dmd.Domain.Entities;

namespace Application.Specifications
{
    public class CategoriesWithImages : Specification<Category>
    {
        public CategoriesWithImages(int parentId)
        {
            Query.Where(e => e.ParentId == parentId);
        }
    }
}
