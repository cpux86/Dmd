using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Interfaces
{
    public interface IProductRepository
    {
        bool Add(Product product, int id);
        IEnumerable<Product> Find(Func<Product, Boolean> predicate);
        string GetAll();
    }
}
