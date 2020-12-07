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
        public void Add()
        {
            Category category = new Category { Title = "Root" };


            CategoryRepository repo = new CategoryRepository();
            repo.Add(category);
            
        }

        [Fact]
        public void AddToCategory()
        {
            CategoryRepository repo = new CategoryRepository();
            Category item = new Category { Title = "Item1" };
            
            repo.AddToCategory(item, 1);

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
