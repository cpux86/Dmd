using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dmd.Domain.Repository
{
    public class ProductRepository
    {
        private readonly ApplicationContext _db;
        public ProductRepository()
        {
            this._db = new ApplicationContext();
        }
        #region CREATE
        /// <summary>
        /// Добавить продукты в категорию по id
        /// </summary>
        /// <param name="product"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AddProductToCategory(List<Product> product, int id)
        {
            Category cat = _db.Category.FirstOrDefault(c => c.Id == id);
            if (cat != null)
            {
                cat.Products.AddRange(product);
                _db.SaveChanges();
                return true;
            }
            return false;
        }
        #endregion
        #region READ
        /// <summary>
        /// Получить продукты по id категории
        /// </summary>
        /// <param name="Id">идентификатор категории</param>
        /// <returns></returns>
        public Category GetProductsByCategoryId(int Id)
        {
            return _db.Category.Include(p => p.Products).FirstOrDefault(c => c.Id == Id);
        }

        /// <summary>
        /// Получить весе элементы (продуктовы), из источника (категории)
        /// </summary>
        /// <param name="dataSource">Объкт категории источника</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsAll(Category dataSource)
        {
            return dataSource.Products.ToList();
        }
        /// <summary>
        /// Получить диапазон элементов (продуктов) из источника (категории)
        /// </summary>
        /// <param name="dataSource">Объкт категории источника</param>
        /// <param name="start">номер старотовой позиции элемента в источнике</param>
        /// <param name="count">количество запрашиваетмых элеменов</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsRange(Category dataSource, int start, int count)
        {
            return dataSource.Products.Skip(start - 1).Take(count).ToList();
        }
        /// <summary>
        /// Получить весь диапазон элементов (продуктов), начиная со start, из источника (категории)
        /// </summary>
        /// <param name="dataSource">Объкт категории источника</param>
        /// <param name="start">номер старотовой позиции элемента в источнике</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProductsRange(Category dataSource, int start)
        {
            return dataSource.Products.Skip(start - 1).ToList();
        }
        /// <summary>
        /// Возвращает количество элементов (товаров) в источнике (категории)
        /// </summary>
        /// <param name="dataSource">Объект источника данных (категория)</param>
        /// <returns></returns>
        public int ProductCounter(Category dataSource) {
            return dataSource.Products.Count;
        }

        #endregion
        #region UPDATE

        #endregion
        #region DELETE
        /// <summary>
        /// Удалить категорию по имени
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            //Category cat = _db.Category.Include(c => c.Products).FirstOrDefault(p => p.Title == name);
            _db.Category.Remove(cat);
            _db.SaveChanges();
        }
        #endregion



        ///// <summary>
        ///// Вернуть все товары из БД
        ///// </summary>
        ///// <returns></returns>
        //public IEnumerable<Product> GetProductList()
        //{
        //    return _db.Product.ToList();
        //}

        
        ///// <summary>
        ///// Вернуть все товары пользователя
        ///// </summary>
        ///// <param name="guid">Guid пользователя</param>
        ///// <returns></returns>
        //public IEnumerable<Product> GetUserProductsByGuid(string guid)
        //{
        //    //return _db.Product.Where()
        //}
    }
}
