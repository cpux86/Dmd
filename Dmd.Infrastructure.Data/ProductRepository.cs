using Dmd.Domain.Interfaces;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dmd.Infrastructure.Data
{
    class ProductRepository : IProductRepository
    {
        private readonly ProductContext db;
        public ProductRepository()
        {
            this.db = new ProductContext();
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
    }
}
