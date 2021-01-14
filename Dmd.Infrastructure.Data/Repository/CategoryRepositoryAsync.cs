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

        public async void AddCategory(Category category)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                BulkConfig bulkConfig = new BulkConfig { PreserveInsertOrder = true, SetOutputIdentity = true};
                var entities = new List<Category> { category };
                await _db.BulkInsertAsync<Category>(entities, bulkConfig);
                var items = new List<Category>();
                var i = entities.FirstOrDefault();
                foreach (var item in i.Items)
                {
                    item.ParentId = i.Id;
                    items.Add(item);
                }
                await _db.BulkInsertAsync<Category>(items);
                transaction.Commit();
            }
                

            //await _db.AddAsync<T>(entity);
            //await _db.SaveChangesAsync();
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
