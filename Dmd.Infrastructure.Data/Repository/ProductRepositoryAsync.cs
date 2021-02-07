using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Infrastructure.Data.Repository
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>
    {
        CatalogContext _db;
        public ProductRepositoryAsync(CatalogContext db) : base(db)
        {
            _db = db;
        }
    }
}
