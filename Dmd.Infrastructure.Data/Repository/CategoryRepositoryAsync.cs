using Application.Interfaces.Repository;
using Dmd.Domain.Entities;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Infrastructure.Data.Repository
{
    public class CategoryRepositoryAsync : GenericRepositoryAsync<Category>, ICategoryRepositoryAsync
    {
        private readonly CatalogContext _db;
        public CategoryRepositoryAsync(CatalogContext context) : base(context)
        {
            _db = context;           
        }

        /// <summary>
        /// Существует ли категория с указанным id
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public bool IsExist(int catId)
        {
            //return _db.Categories.Where(e => e.Id == catId).Any();
            return _db.Categories.Any(e => e.Id == catId);
        }

        /// <summary>
        /// Получить весь список категорий
        /// </summary>
        /// <returns></returns>
        //public async Task<IReadOnlyList<Category>> GetCategoryList(int categoryId)
        //{
        //    return await _db.Set<Category>().Where(e => e.ParentId == categoryId).Include(e => e.Items).ToListAsync();
        //}

        //public async Task<IReadOnlyList<Category>> GetListByParentId(int parentId)
        //{
        //    ////var r = await _db.Set<Category>().CountAsync(e=>e.Title == "Level 1");
        //    //return await _db.Set<Category>().Where(predicate).Select(x => new { x.Title, x.ImageUrl }).ToListAsync<Category>();
        //    //return await _db.Set<Category>().Where(predicate).ToListAsync();

        //}
    }
}
