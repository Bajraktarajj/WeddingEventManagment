using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Domain.Models;  // Ensure this matches the namespace where Contact is defined

public class WeedingEventManagmentDbContext : DbContext
{
    public WeedingEventManagmentDbContext(DbContextOptions<WeedingEventManagmentDbContext> options)
        : base(options) { }

    public DbSet<Contact> Contacts { get; set; }
}
