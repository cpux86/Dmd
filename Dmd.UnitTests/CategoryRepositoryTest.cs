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
        [Fact]
        public void AddUser()
        {
            User user = new User() { /*FirstName = "Владимир",*/ LastName = "Каськов", Email = "cpux86@mail.ru", Phone = "+79997961175" };
            UserRepository rep = new UserRepository();
            rep.CreateUser(user);
            rep.Save();
        }
        [Fact]
        public void CreateUser()
        {
            User user = new User() { FirstName = "Владимир", LastName = "Каськов", Email = "cpux86@mail.ru", Phone = "+79997961175" };

        }
        /// <summary>
        /// Создать новую категорию
        /// </summary>
        [Fact]
        public void CreateCategory()
        {
            Category catalog = new Category() { Title = "КАтегория 2", ParentId = 1 };
            CategoryRepository rep = new CategoryRepository();
            rep.Add(catalog);
        }
        [Fact]
        public void CreateProduct()
        {
            CategoryRepository catalogRepository = new CategoryRepository();
            //Catalog catalog = catalogRepository.GetCatalogByName("Ноутбук");
            Category catalog = new Category() { Title = "Компьютерная техника" };
            
            Product product = new Product() { 
                Title = "Ноутбук",
                Description = "Ультратонкий ноутбук с мощьным процессором и более 12 часов работы от батареи",
                Catalog = catalog
            };
            ProductRepository productRepository = new ProductRepository();
            productRepository.AddProduct(product);
        }
        /// <summary>
        /// получить категории - сестра
        /// </summary>
        [Fact]
        public void GetCategoryListTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var collection = categoryRepository.GetCategoryList(1).OrderByDescending(c => c.Sort).Select(c => c.Title);


            foreach (var item in collection)
            {
                var i = item;
            }
        }
        /// <summary>
        /// Добавить категорию
        /// </summary>
        [Fact]
        public void AddToCategoryTest()
        {
            Category category = new Category() { Title = "Новая категория 2" };
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.AddToCategory(2, category);

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
    }
}
