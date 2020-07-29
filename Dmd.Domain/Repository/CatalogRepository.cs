using Dmd.Domain.Modeles;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Repository
{
    class CatalogRepository
    {
        private readonly ApplicationContext _db;
        public CatalogRepository()
        {
            this._db = new ApplicationContext();
        }
        /// <summary>
        /// Создать коталог
        /// </summary>
        /// <param name="catalog"></param>
        public void Create(Catalog catalog)
        {
            _db.Add(catalog);
            _db.SaveChangesAsync();
        }
    }
}
