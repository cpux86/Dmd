using Dmd.Domain.Interfaces;
using Dmd.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dmd.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext db;
        public ProductRepository()
        {
            this.db = new ApplicationContext();
        }

        public bool Add(Product product, int id)
        {
            Category cat = db.Categories.FirstOrDefault(c=>c.Id == id);
            if (cat != null)
            {
                cat.Products.Add(product);
                db.SaveChanges();
                return true;
            }
            return true;
        }

        public IEnumerable<Product> Find(Func<Product, Boolean> predicate)
        {
            return db.Products.Where<Product>(predicate).ToList();
        }

        public string GetAll()
        {
            return "Hello World";
        }
    }
}
