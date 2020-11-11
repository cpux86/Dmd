using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Dmd.Domain.Core.Entities;
using Microsoft.Extensions.Logging;

namespace Dmd.Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{
        //    Database.EnsureCreated();   // создаем базу данных при первом обращении
        //}
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
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
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);

        }
        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            //builder.AddConsole();
            builder.AddProvider(new MyLoggerProvider());    // указываем наш провайдер логгирования
        });
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>()
            //    .HasOne(p => p.Parent).WithMany(c => c.Children).OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<Category>().HasData(new Category { Id = 1, LeftKey = 1, RightKey = 2, Level = 0, Parent = 0, DateModified = DateTime.Now }) ;
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        @"Server = localhost; Database = ef; User = root; Password = ;");
        //}
    }
}
