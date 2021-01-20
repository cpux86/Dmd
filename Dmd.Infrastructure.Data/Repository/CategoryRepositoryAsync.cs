using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces.Repository;
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
        private readonly ApplicationContext _db;
        public CategoryRepositoryAsync(ApplicationContext context) : base(context)
        {
            _db = context;         
            
        }


        public async Task<bool> CategoryExist(Expression<Func<Category, bool>> predicate)
        {
            return await _db.Categories.Where(predicate).AnyAsync();
        }

        //public async void AddCategoryAsync(Category category, Category parentCategory = null)
        //{
        //    //_db.Categories.FirstOrDefault<Category>(e=>e.Id== );
        //    //_db.Find<Category>(parentCategory);
        //    //parentCategory.Items.Add(category);
        //    //using (var transaction = _db.Database.BeginTransaction())
        //    //{
        //    //    BulkConfig bulkConfig = new BulkConfig { PreserveInsertOrder = true, SetOutputIdentity = true, CalculateStats = true};
        //    //    await _db.BulkInsertAsync<Category>(category, bulkConfig);
        //    //    transaction.Commit();
        //    //    var test = bulkConfig.CalculateStats;
        //    //}
                

        //    //await _db.SaveChangesAsync();
        //}

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
