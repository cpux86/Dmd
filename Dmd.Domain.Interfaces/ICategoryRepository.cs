using Dmd.Domain.Modeles.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        void Create(Category category);
        IEnumerable<Category> Find(Func<Category, Boolean> predicate);
    }
}
