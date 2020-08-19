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
        public void AddProductToCategoryTest()
        {
            ProductRepository productRepository = new ProductRepository();
            List<Product> products = new List<Product>()
            {
                new Product {Title="Яблоки"},
                new Product {Title ="Груши"},
                new Product {Title ="Бананы"},
                new Product {Title ="Мандарины"}
            };
            var result = productRepository.AddProductToCategory(products, 2);
        }

        [Fact]
        public void RemoveProduct()
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.Remove(7);
        }
        /// <summary>
        /// получить содержимое категории
        /// </summary>
        [Fact]
        public void GetProductsByCategoryTest()
        {
            ProductRepository productRepository = new ProductRepository();
            var result = productRepository.GetProductsByCategoryId(4);
        }
        /// <summary>
        /// получить диапазон продуктов из категории
        /// </summary>
        [Fact]
        public void GetProductsRangeTest()
        {
            ProductRepository productRepository = new ProductRepository();
            Category category = productRepository.GetProductsByCategoryId(2);
            IEnumerable<Product> products;
            if (category != null)
            {
                products = productRepository.GetProductsRange(category,5,5);
            }
        }
        // Кличестово продуктов в категории
        [Fact]
        public void ProductCounterTest()
        {
            ProductRepository productRepository = new ProductRepository();
            Category category = productRepository.GetProductsByCategoryId(2);
            int count = productRepository.ProductCounter(category);
        }
    }
}
