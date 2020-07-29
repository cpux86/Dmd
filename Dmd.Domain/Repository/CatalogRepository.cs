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
    public class CatalogRepository
    {
        private readonly ApplicationContext _db;
        public CatalogRepository()
        {
            this._db = new ApplicationContext();
        }
        /// <summary>
        /// Создать каталог
        /// </summary>
        /// <param name="catalog"></param>
        public void Create(Category catalog)
        {
            _db.Add(catalog);
            _db.SaveChangesAsync();
        }
        /// <summary>
        /// Получить весь список категорий
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Category> GetCatalogList()
        {
            return _db.Catalogs;
        }
        /// <summary>
        /// Получить каталог по имени
        /// </summary>
        /// <returns></returns>
        public Category GetCatalogByName(string catalog)
        {
            return _db.Catalogs.FirstOrDefault(c => c.Id == 1);
        }
    }
}
