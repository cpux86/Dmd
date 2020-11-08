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
            Category category = new Category { Title = "√лавное меню"};
            CategoryRepository repo = new CategoryRepository();
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
            var res = repo.Find(c => c.Title == "‘рукты" || c.Title == "ќвощи");
        }
        [Fact]
        public void DeleteCategoryByIdTest()
        {
            CategoryRepository repo = new CategoryRepository();
            repo.DeleteCategoryById(6);
        }


    }
}
