using Microsoft.EntityFrameworkCore;
using PShop.Models.DBEntities;

namespace PShop.Models.DBEFContext
{
    public class PShopContext : DbContext
    {
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Teams> Teams { get; set; }
        public DbSet<Players> Players { get; set; }

        public PShopContext(DbContextOptions<PShopContext> options) 
            : base(options)
        {

        }
    }
}
