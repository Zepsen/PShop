using Microsoft.EntityFrameworkCore;
using PShop.Models.DBEntities;

namespace PShop.Models.DBEFContext
{
    public class PShopContext : DbContext
    {
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public PShopContext(DbContextOptions<PShopContext> options) 
            : base(options)
        {

        }
    }
}
