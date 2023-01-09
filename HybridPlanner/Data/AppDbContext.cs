using HybridPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace HybridPlanner.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet<Party> Parties { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
