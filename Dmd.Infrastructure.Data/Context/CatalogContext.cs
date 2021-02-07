﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Dmd.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using Dmd.Domain.ValueObject.Property;

namespace Dmd.Infrastructure.Data
{
    public class CatalogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Properties> Properties { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<PropertyData> Property_Datas { get; set; }

        public CatalogContext()
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
            //builder.AddProvider(new MyLoggerProvider());    // указываем наш провайдер логгирования
        });

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql(
        //        @"Server = localhost; Database = ef; User = root; Password = ;");
        //}
    }
}