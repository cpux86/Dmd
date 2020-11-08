using Dmd.Domain.Core;
using Dmd.Domain.Core.Entities;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Infrastructure.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationContext db;
        public CategoryRepository()
        {
            this.db = new ApplicationContext();
        }

        public IEnumerable<Category> Find(Func<Category, bool> cat)
        {
            return db.Categories.Where(cat).ToList();
        }

        #region CREATE
        /// <summary>
        /// Создать категорию
        /// </summary>
        /// <param name="category"></param>
        public void Add(Category category)
        {
            //category.Parent = 0;
            //var cat = db.Categories.Max<Category>(e => e.RightKey);
            ////var cat = new Category { RightKey = 1 };
            //var cat = db.Categories.FirstOrDefault<Category>(c => c.RightKey == 0);
            //cat.RightKey = 5;
            //IEnumerable<Category> cat = db.Categories.Where<Category>(c => c.RightKey > 0).ToList<Category>();
            //db.Categories.Where<Category>(e => e.RightKey > 0).ForEachAsync<Category>(e => e.RightKey = 2);
            //db.Categories.Add(category);
            //IQueryable<Category> res = db.Categories.Where<Category>(c => c.LeftKey > 0);
            //Category res = new Category { Id = 3 };
            //db.Entry(res).State = EntityState.Deleted;
            //int number = db.Database.ExecuteSqlRaw("UPDATE Categories SET RightKey={0}, Level = (RightKey * 5) WHERE RightKey > {1}", 101, 0);


            int categoryId = 1;
            

            Category parentCategory = db.Categories.Where<Category>(e => e.Id == categoryId).FirstOrDefault();

            category.LeftKey = parentCategory.RightKey;
            category.RightKey = parentCategory.RightKey + 1;
            category.Level = parentCategory.Level + 1;
            category.Parent = parentCategory.Id;
            category.DateModified = DateTime.Now;

            // 1. Обновляем ключи существующего дерева
            db.Categories.Where<Category>(e => e.LeftKey > parentCategory.RightKey).BatchUpdate<Category>(e => new Category { LeftKey = e.LeftKey + 2, RightKey = e.RightKey + 2 });
            // 2. Обновляем родительскую ветку
            db.Categories.Where<Category>(e => e.RightKey >= parentCategory.RightKey && e.LeftKey < parentCategory.RightKey).BatchUpdate<Category>(e => new Category { RightKey = e.RightKey + 2 });


            db.Categories.Add(category);
            db.SaveChanges();

        }
        /// <summary>
        /// Добавить в категрию
        /// </summary>
        /// <param name="id">идентификатор категории</param>
        /// <param name="cat">категория для добовления</param>
        public void AddToCategory(string name, Category cat)
        {
            Category item = db.Categories.FirstOrDefault(c => c.Title == name);
            //item.Children.Add(cat);
            db.SaveChanges();
        }
        /// <summary>
        /// Копировать категорию
        /// </summary>
        /// <param name="category"></param>
        /// <param name="dest"></param>
        public void Copy(Category category, Category dest)
        {

        }
        #endregion
        #region READ
        /// <summary>
        /// Получить весь список категорий
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Category> GetCategoryList()
        {
            return db.Categories;
        }
        /// <summary>
        /// Получить категорию по id
        /// </summary>
        /// <param name="id">идентификатор зарашиваемой категории</param>
        /// <returns></returns>
        public Category GetCategoryById(int id)
        {
            return db.Categories.Where(c => c.Id == id).FirstOrDefault();
        }


        /// <summary>
        /// Определяет, сществует заданная категория
        /// </summary>
        /// <param name="id">идентификатор проверяемой категории</param>
        /// <returns></returns>
        public bool Exists(int id)
        {
            return db.Categories.Any(c => c.Id == id);
        }
        /// <summary>
        /// Определяе, существует категория с заданным именем
        /// </summary>
        /// <param name="catName">имя проверяемой категории</param>
        /// <returns></returns>
        public bool ExistsCategoryName(string catName)
        {
            return db.Categories.Any(c => c.Title == catName);
        }
        /// Получить длинну 
        public int GetCount()
        {
            return db.Categories.Count<Category>();
        }

        #endregion
        #region UPDATE
        /// <summary>
        /// Редактировать категорию
        /// </summary>
        public void Edit(Category category)
        {

        }
        /// <summary>
        /// Перемещения категории
        /// </summary>
        public void Move(int sourceId, int destId)
        {
            /* Категория может ссылаться на любую категорию кроме дочерних
             * Поиск возможных вариантов перемещения
             * Перенос возможен:
             * 1. в категории одного уровня (брат, сестра), и их подкатегории, кроме себя.
             * 2. в категорию верхнего уровня
             */

        }
        #endregion
        #region DELETE
        /// <summary>
        /// Удалить категорию по id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCategoryById(int id)
        {


        }
        #endregion
        #region Helper
        public IEnumerable<Category> GetPreViewResult(string searchStr)
        {
            //return _db.Category.Where(c => c.Title.ToLower().Contains(searchStr.ToLower()));
           return db.Categories.Where<Category>(c => EF.Functions.Like(c.Title.ToUpper(), $"%{searchStr.ToLower()}%"));
            //return _db.Category.Where<Category>(c => EF.Functions.FreeText(c.Title, searchStr));
        }
        #endregion
    }
}
