using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Domain.Repository
{
    public class CategoryRepository
    {
        private readonly ApplicationContext _db;
        public CategoryRepository()
        {
            this._db = new ApplicationContext();
        }
        #region CREATE
        /// <summary>
        /// Создать категорию
        /// </summary>
        /// <param name="category"></param>
        public void Add(Category category)
        {
            _db.Add(category);
            _db.SaveChanges();
        }
        /// <summary>
        /// Добавить в категрию
        /// </summary>
        /// <param name="id">идентификатор категории</param>
        /// <param name="category">категория для добовления</param>
        public void AddToCategory(int id, Category category)
        {
            category.ParentId = id;
            _db.Category.Add(category);
            _db.SaveChanges();
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
            return _db.Category;
        }
        /// <summary>
        /// Получить категорию по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategoryById(int id)
        {
            return _db.Category.Where(c => c.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Получить содержимое категории
        /// </summary>
        /// <param name="categoryId">идентификатор категории</param>
        /// <returns></returns>
        public IQueryable<Category> GetCategoryList(int categoryId)
        {
            return _db.Category.Where<Category>(c => c.ParentId == categoryId);
        }

        /// <summary>
        /// Получить категорию по имени
        /// </summary>
        /// <returns></returns>
        public Category GetCategoryByName(string catalog)
        {
            return _db.Category.FirstOrDefault(c => c.Id == 1);
        }
        /// <summary>
        /// Определяет, сществует заданная категория
        /// </summary>
        /// <param name="id">идентификатор проверяемой категории</param>
        /// <returns></returns>
        public bool Exists(int id)
        {
            return _db.Category.Any(c => c.Id == id);
        }
        /// <summary>
        /// Определяе, существует категория с заданным именем
        /// </summary>
        /// <param name="catName">имя проверяемой категории</param>
        /// <returns></returns>
        public bool ExistsCategoryName(string catName)
        {
            return _db.Category.Any(c => c.Title == catName);
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
        /// Удалить категорию
        /// </summary>
        /// <param name="category"></param>
        public void Delete(Category category)
        {

        }
        #endregion
        #region Helper
        public IEnumerable<Category> GetPreViewResult(string searchStr)
        {
            //return _db.Category.Where(c => c.Title.ToLower().Contains(searchStr.ToLower()));
            return _db.Category.Where<Category>(c=>EF.Functions.Like(c.Title.ToUpper(), $"%{searchStr.ToLower()}%"));
            //return _db.Category.Where<Category>(c => EF.Functions.FreeText(c.Title, searchStr));
        }
        #endregion
    }
}
