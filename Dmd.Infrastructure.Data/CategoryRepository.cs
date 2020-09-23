using Dmd.Domain.Interfaces;
using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dmd.Infrastructure.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ProductContext db;
        public CategoryRepository()
        {
            this.db = new ProductContext();
        }

        public void Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Where<Category>(predicate).ToList();
        }
    }
}
