using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Presistent
{
    public class WeedingEventManagmentDbContext : DbContext
    {
        public WeedingEventManagmentDbContext(DbContextOptions<WeedingEventManagmentDbContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Wedding> Wedding { get; set; }
    }
}
