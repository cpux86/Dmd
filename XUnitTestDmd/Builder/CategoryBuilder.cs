using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTests.Builder
{
    public class CategoryBuilder
    {
        private Category _category;

        public CategoryBuilder()
        {
            _category = new Category
            {
                Title = "Тестовая категория",
                Description = "Описание тестовой категоии",
                ImageUrl = "https://img.dmd.ru/img.jpg"
            };
        }
        public Category Build()
        {
            return _category;
        }
        public Category RootCategoryWidthAudit()
        {
            _category.DateModified = DateTime.UtcNow;
            return _category;
        }
    }
}
