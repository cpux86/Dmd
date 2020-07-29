using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dmd.Domain.Repository
{
    class ProductRepository : BaseRepository
    {
        private readonly ApplicationContext _db;
        public ProductRepository()
        {
            this._db = new ApplicationContext();
        }

        public void AddProduct(Product product)
        {
            _db.Add(product);
            _db.SaveChangesAsync();
        }

        /// <summary>
        /// Вернуть все товары из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProductList()
        {
            return _db.Product;
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
