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
            User user = new User() { /*FirstName = "��������",*/ LastName = "�������", Email = "cpux86@mail.ru", Phone = "+79997961175" };
            UserRepository rep = new UserRepository();
            rep.CreateUser(user);
            rep.Save();
        }
        [Fact]
        public void CreateUser()
        {
            User user = new User() { FirstName = "��������", LastName = "�������", Email = "cpux86@mail.ru", Phone = "+79997961175" };

        }
        /// <summary>
        /// ������� ����� ���������
        /// </summary>
        [Fact]
        public void CreateCategory()
        {
            Category catalog = new Category() { Title = "��������� 2", ParentId = 1 };
            CategoryRepository rep = new CategoryRepository();
            rep.Add(catalog);
        }
        [Fact]
        public void CreateProduct()
        {
            CategoryRepository catalogRepository = new CategoryRepository();
            //Catalog catalog = catalogRepository.GetCatalogByName("�������");
            Category catalog = new Category() { Title = "������������ �������" };
            
            Product product = new Product() { 
                Title = "�������",
                Description = "������������ ������� � ������� ����������� � ����� 12 ����� ������ �� �������",
                Catalog = catalog
            };
            ProductRepository productRepository = new ProductRepository();
            productRepository.AddProduct(product);
        }
        /// <summary>
        /// �������� ��������� - ������
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
        /// �������� ���������
        /// </summary>
        [Fact]
        public void AddToCategoryTest()
        {
            Category category = new Category() { Title = "����� ��������� 2" };
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
            var collection = categoryRepository.GetPreViewResult("���");
            foreach (var item in collection)
            {
                var res = item.Title;
            }
        }
    }
}
