using Dmd.Domain.Modeles.Entityes;
using Microsoft.EntityFrameworkCore;


namespace Dmd.Infrastructure.Data
{
    class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{
        //    Database.EnsureCreated();   // создаем базу данных при первом обращении
        //}
        public ProductContext()
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=(localdb)\MSSQLLocaldb;Database=Blogging;Integrated Security=True");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Mobile.db");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        @"Server = localhost; Database = ef; User = root; Password = ;");
        //}
    }
}
