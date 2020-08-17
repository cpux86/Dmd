using Dmd.Domain.Modeles.Entityes;
using Dmd.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace Dmd.UnitTests
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void AddProductTest()
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> products = new List<Product>()
            {
                new Product {Title="Яблоки"},
                new Product {Title ="Груши"},
                new Product {Title ="Бананы"},
                new Product {Title ="Мандарины"}
            };
            //Product product = new Product();
            //product.Title = "Яблоки";
            productRepository.AddProduct(products, "Фрукты");
        }

        [Fact]
        public void RemoveProductTest()
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Remove("Бананы");
        }
        [Fact]
        public void GetProductListTest()
        {
            ProductRepository productRepository = new ProductRepository();
            var productList = productRepository.GetProductList();
        }
        /// <summary>
        /// получить содержимое категории
        /// </summary>
        [Fact]
        public void GetCategoryListTest()
        {
            ProductRepository productRepository = new ProductRepository();
            var list = productRepository.GetCategoryList(2);
        }
    }
}
