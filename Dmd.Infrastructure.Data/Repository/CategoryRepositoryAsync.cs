using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Infrastructure.Data.Repository
{
    public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
    {
        private readonly ApplicationContext _db;
        public CategoryRepositoryAsync()
        {
            _db = new ApplicationContext();
        }

        /// <summary>
        /// Получить весь список категорий
        /// </summary>
        /// <returns></returns>
        public async Task<IReadOnlyList<Category>> GetCategoryList(int categoryId)
        {
            return await _db.Set<Category>().Where(e => e.ParentId == categoryId).Include(e => e.Items).ToListAsync();
        }
    }
}
