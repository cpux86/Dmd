using Dmd.Domain.Core.Entities;
using Dmd.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestDmd
{
    public class CategoryRepositoryTest
    {
        [Fact]
        public void Create()
        {
            List<Category> cat = new List<Category>
            {
                new Category { Title = "Кат"},
                new Category { Title = "Кат 2"},
                new Category { Title = "Кат 3"},
                new Category { Title = "Кат 4"},
            };


            CategoryRepository repo = new CategoryRepository();
            repo.Add(cat);
            
        }
        [Fact]
        public void GetCategoryByIdTest()
        {
            CategoryRepository repo = new CategoryRepository();
            var result = repo.GetCategoryById(1);
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


    }
}
