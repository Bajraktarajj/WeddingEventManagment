using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

public class WeedingEventManagmentDbContext : DbContext
{
    public WeedingEventManagmentDbContext(DbContextOptions<WeedingEventManagmentDbContext> options)
        : base(options) { }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Wedding> Wedding { get; set; } // Ensure this property is defined for Wedding as well
}
