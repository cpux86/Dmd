using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Dmd.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;

namespace Dmd.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=(localdb)\MSSQLLocaldb;Database=Blogging;Integrated Security=True");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory)
                .EnableSensitiveDataLogging()
                .UseSqlite("Filename=Mobile.db");

        }
        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            //builder.AddConsole();
            builder.AddProvider(new MyLoggerProvider());    // указываем наш провайдер логгирования
        });

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        @"Server = localhost; Database = ef; User = root; Password = ;");
        //}
    }
}
