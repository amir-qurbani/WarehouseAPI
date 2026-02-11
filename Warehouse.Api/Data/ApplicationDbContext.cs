using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Models; // Denna rad måste stämma exakt med Product.cs

namespace WarehouseAPI.Data // Se till att namnet matchar mappen
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}