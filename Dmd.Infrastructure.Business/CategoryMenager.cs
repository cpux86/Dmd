using Dmd.Domain.Entities;
using Dmd.Infrastructure.Data;
using Dmd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Infrastructure.Business
{
    public class CategoryMenager : ICategoryManager
    {
        private readonly ApplicationContext _context;
        private Category _category;

        public CategoryMenager(ApplicationContext context)
        {
            _context = context;
        }

        public Category Create(Category category)
        {
            _category = category;
            _category.DateModified = DateTimeOffset.UtcNow;
            return category;
        }

        //public void Delete(int catId)
        //{

        //    throw new NotImplementedException();
        //}

        //public async void Save()
        //{
        //    await _context.AddAsync(_category);
        //}
    }
}
