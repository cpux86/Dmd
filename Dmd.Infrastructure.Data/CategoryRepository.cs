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
            db.Categories.Add(category);
            db.SaveChangesAsync();
        }
        public void AddRange(IList<Category> category)
        {
            db.BulkInsertAsync(category);
        }
        /// <summary>
        /// Добавить в категрию
        /// </summary>
        /// <param name="id">идентификатор категории</param>
        /// <param name="cat">категория для добовления</param>
        public void AddToCategory(Category cat, int parentId)
        {
            Category item = db.Categories.Where(c => c.Id == parentId).FirstOrDefault();
            item.Children = new List<Category>() { cat };
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
            return db.Categories.Where(e => e.Title == "Level 1").ToList();
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
