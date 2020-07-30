using Dmd.Domain.Modeles.Entityes;
using Dmd.Domain.Repository;
using System;
using Xunit;
using Xunit.Sdk;

namespace Dmd.UnitTests
{
    public class UnitUser
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
            Category catalog = new Category() { Title = "Категория 1" };
            CategoryRepository rep = new CategoryRepository();
            rep.Create(catalog);
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
        /// добавить вложенную категорию
        /// </summary>
        [Fact]
        public void AddItemCategoryTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.CreateChildsCategory();
        }
    }
}
