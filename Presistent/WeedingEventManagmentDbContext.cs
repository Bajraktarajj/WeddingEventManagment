using Microsoft.EntityFrameworkCore;

namespace Presistent
{
    public class WeedingEventManagmentDbContext : DbContext
    {
        public WeedingEventManagmentDbContext(DbContextOptions<WeedingEventManagmentDbContext> options)
            : base(options) {
        }
        
        public virtual DbSet<Wedding> Patient { get; set; }

    }
}
