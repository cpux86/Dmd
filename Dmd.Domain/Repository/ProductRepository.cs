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
        /// <summary>
        /// Добавить продукты в категорию по id
        /// </summary>
        /// <param name="product"></param>
        /// <param name="categoryId"></param>
        public void AddProduct(List<Product> product, string name)
        {
            Category cat = _db.Category.FirstOrDefault(c => c.Title == name);
            cat.Products.AddRange(product);
            _db.SaveChanges();
        }
        /// <summary>
        /// Удалить категорию по имени
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Category cat = _db.Category.Include(p => p.Products).FirstOrDefault();
            _db.Category.Remove(cat);
            _db.SaveChanges();
        }

        /// <summary>
        /// Вернуть все товары из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProductList()
        {
            return _db.Product.ToList();
        }

        /// <summary>
        /// Получить содержимое категории
        /// </summary>
        /// <param name="categoryId">идентификатор категории</param>
        /// <returns></returns>
        public ICollection<Product> GetCategoryList(int categoryId)
        {
            Category item = _db.Category.Include(p => p.Products).First(c => c.Id == categoryId);
            return item.Products.ToList();
        }
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
