using Dmd.Domain.Core.Entities;
using Dmd.Infrastructure.Data;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestDmd
{
    public class CategoryRepositoryTest
    {
        [Fact]
        public void Create()
        {
            CategoryRepository repo = new CategoryRepository();
            Category category = new Category() { Title = "Категория 0", ParentId = 0 };
            repo.Add(category);
            
        }
        [Fact]
        public void GetCategoryByIdTest()
        {
            CategoryRepository repo = new CategoryRepository();
            var result = repo.GetCategoryById(2);
        }
        [Fact]
        public void Find()
        {
            CategoryRepository repo = new CategoryRepository();
            var res = repo.Find(c => c.Title == "Фрукты" || c.Title == "Овощи");
        }
        [Fact]
        public void DeleteCategoryByIdTest()
        {
            CategoryRepository repo = new CategoryRepository();
            repo.DeleteCategoryById(6);
        }

        [Fact]
        public void GetByIdTest()
        {
            CategoryRepository repo = new CategoryRepository();
        }
        [Fact]
        public void GetCategoryListTest()
        {
            CategoryRepository repo = new CategoryRepository();
            //var res = repo.GetCategoryList();
        }

    }
}
