using Dmd.Domain.Entities;
using Dmd.Infrastructure.Data;
using Dmd.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTests.Repositories.CategoriesRepository
{
    public class CategoryRepositoryTest
    {
        /// <summary>
        /// Добавить категорию в корень
        /// </summary>
        [Fact]
        public async void AddCategoryToRoot()
        {
            CatalogContext context = new CatalogContext();
            Category category = new Category { Title = "Новая категория", Description = "Описание новой категории" };


            CategoryRepositoryAsync repo = new CategoryRepositoryAsync(context);
            await repo.AddAsync(category);

        }

        //[Fact]
        //public void AddToCategory()
        //{
        //    CategoryRepository repo = new CategoryRepository();
        //    Category item = new Category { Title = "Item1" };

        //    repo.AddToCategory(item, 1);

        //}

        //[Fact]
        //public void GetCategoryByIdTest()
        //{
        //    CategoryRepository repo = new CategoryRepository();
        //    var result = repo.GetCategoryById(1);
        //}
        //[Fact]
        //public void Find()
        //{
        //    CategoryRepository repo = new CategoryRepository();
        //    var res = repo.Find(c => c.Title == "Фрукты" || c.Title == "Овощи");
        //}
        //[Fact]
        //public void DeleteCategoryByIdTest()
        //{
        //    CategoryRepository repo = new CategoryRepository();
        //    repo.DeleteCategoryById(6);
        //}


    }
}
