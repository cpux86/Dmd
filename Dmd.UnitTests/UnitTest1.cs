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
        [Fact]
        public void CreateCategory()
        {
            Category catalog = new Category() { Title = "��������" };
            CatalogRepository rep = new CatalogRepository();
            rep.Create(catalog);
        }
        [Fact]
        public void CreateProduct()
        {
            CatalogRepository catalogRepository = new CatalogRepository();
            //Catalog catalog = catalogRepository.GetCatalogByName("�������");
            Category catalog = new Category() { Title = "������������ �������" };
            
            Product product = new Product() { Title = "�������", Description = "������������ ������� � ������� ����������� � ����� 12 ����� ������ �� �������", Catalog = catalog };
            ProductRepository productRepository = new ProductRepository();
            productRepository.AddProduct(product);
        }
    }
}
