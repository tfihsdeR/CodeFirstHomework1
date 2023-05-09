using CodeFirstHomework1.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstHomework1.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=AlohaECommerceDb; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
