// Extensions/ServiceExtensions.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Data; // Replace with your actual namespace containing the DbContext class

namespace YourNamespace.Extensions // Replace with your actual namespace
{
    public static class ServiceExtensions
    {
        // This method registers the DbContext with the DI container
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Use the correct DbContext class name and connection string key from your appsettings.json
            services.AddDbContext<WeedingEventManagmentDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
