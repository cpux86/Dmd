using Dmd.Domain.Core.Entities;
using System.Collections.Generic;

namespace Dmd.Infrastructure.Data
{
    public interface ICategoryRepository
    {
        int Add(Category category);
        void AddToCategory(string name, Category cat);
        void Copy(Category category, Category dest);
        void DeleteCategoryById(int id);
        void Edit(Category category);
        bool Exists(int id);
        bool ExistsCategoryName(string catName);
        Category GetCategoryById(int id);
        //IEnumerable<Category> GetCategoryList();
        int GetCount();
        IEnumerable<Category> GetPreViewResult(string searchStr);
        void Move(int sourceId, int destId);
    }
}