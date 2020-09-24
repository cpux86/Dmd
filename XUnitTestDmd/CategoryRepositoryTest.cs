using Dmd.Domain.Modeles.Entityes;
using Dmd.Infrastructure.Data;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestDmd
{
    public class CategoryRepositoryTest
    {
        [Fact]
        public void Create()
        {
            Category category = new Category { Title = "�����" };
            CategoryRepository repo = new CategoryRepository();
            repo.Add(category);
        }
        [Fact]
        public void Get()
        {
            CategoryRepository repo = new CategoryRepository();
            var res = repo.Find(c => c.Title == "������" || c.Title == "�����");
        }
    }
}
