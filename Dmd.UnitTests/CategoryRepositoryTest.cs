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
            Category catalog = new Category() { Title = "������"};
            CategoryRepository rep = new CategoryRepository();
            rep.Add(catalog);
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
        /// �������� ��������� � ���������
        /// </summary>
        [Fact]
        public void AddToCategoryTest()
        {
            Category category = new Category() { Title = "������������" };
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.AddToCategory("��������� 1", category);

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

        [Fact]
        public void GetCountTest()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            int count = categoryRepository.GetCount();
        }
        [Fact]
        public void DeleteByName()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.Delete("��������� 1");
        }
    }
}
