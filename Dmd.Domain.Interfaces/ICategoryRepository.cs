using Dmd.Domain.Core.Entities;
using System.Collections.Generic;

namespace Dmd.Infrastructure.Data
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void AddRange(IList<Category> categories);
        void AddToCategory(Category cat, int parentId);
        void Copy(Category category, Category dest);
        void DeleteCategoryById(int id);
        void Edit(Category category);
        bool Exists(int id);
        bool ExistsCategoryName(string catName);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetCategoryList();
        int GetCount();
        IEnumerable<Category> GetPreViewResult(string searchStr);
        void Move(int sourceId, int destId);
    }
}