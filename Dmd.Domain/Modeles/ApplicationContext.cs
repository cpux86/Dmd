using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmd.DataModeles;

namespace Dmd.Domain.Modeles
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        public DbSet<Dmd.DataModeles.Properties> Properties { get; set; }
        public DbSet<Dmd.DataModeles.Product> Product { get; set; }
        public DbSet<Dmd.DataModeles.Order> Order { get; set; }
    }
}
