using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmd.Domain.Modeles.Entityes;
using Microsoft.Extensions.Logging;

namespace Dmd.Domain.Modeles
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Entityes.User> Users { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Category> Category { get; set; }

        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{
        //    Database.EnsureCreated();   // создаем базу данных при первом обращении
        //}
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=(localdb)\MSSQLLocaldb;Database=Blogging;Integrated Security=True");
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Filename=Mobile.db");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                @"Server = localhost; Database = ef; User = root; Password = ;");
        }
    }
}
