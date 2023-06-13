using Microsoft.EntityFrameworkCore;

namespace Armorsmith.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Armor> Armors { get; set; }
    }
}
