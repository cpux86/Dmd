using Dmd.Domain.Modeles.Entityes;
using Microsoft.EntityFrameworkCore;


namespace Dmd.Infrastructure.Data
{
    class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
