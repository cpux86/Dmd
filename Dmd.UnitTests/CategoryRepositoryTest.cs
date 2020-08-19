using Dmd.Domain.Modeles.Entityes;
using Dmd.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace Dmd.UnitTests
{
    public class CategoryRepositoryTest
    {
        /// <summary>
        /// Создать новую категорию
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            Category catalog = new Category() { Title = "Фрукты"};
            CategoryRepository rep = new CategoryRepository();
            rep.Add(catalog);
        }
       

        /// <summary>
        /// Добавить категорию в категорию
        /// </summary>
        [Fact]
        public void AddToCategoryTest()
        {
            Category category = new Category() { Title = "Подкатегория" };
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.AddToCategory("Категория 1", category);

        }
        [Fact]
        public void ExistsTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            bool exists = categoryRepository.Exists(2);


        }
        [Fact]
        public void GetPreViewResultTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var collection = categoryRepository.GetPreViewResult("кат");
            foreach (var item in collection)
            {
                var res = item.Title;
            }
        }

        [Fact]
        public void GetCountTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            int count = categoryRepository.GetCount();
        }
        [Fact]
        public void DeleteCategoryByIdTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.DeleteCategoryById(1);
        }
        [Fact]
        public void GetCategoryByIdTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var result = categoryRepository.GetCategoryById(1);
        }
    }
}
