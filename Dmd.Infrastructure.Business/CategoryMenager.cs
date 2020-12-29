using Dmd.Domain.Entities;
using Dmd.Infrastructure.Data;
using Dmd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Infrastructure.Business
{
    public class CategoryMenager : ICategoryMenager
    {
        private readonly ApplicationContext _context;

        public CategoryMenager(ApplicationContext context)
        {
            _context = context;
        }

        public Category Create(Category category)
        {
            category.DateModified = DateTimeOffset.UtcNow;
            return category;
        }
    }
}
