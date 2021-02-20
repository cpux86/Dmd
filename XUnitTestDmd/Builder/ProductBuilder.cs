using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTests.Builder
{
    public class ProductBuilder
    {
        private Product _product;

        public ProductBuilder()
        {
            _product = WithDefaultValues();
        }
        public Product Build()
        {
            return _product;
        }

        public Product WithDefaultValues()
        {
            _product = new Product { Title = "Тестовый продукт", Description = "Описание тестового продукта" };
            return _product;
        }
    }
}
