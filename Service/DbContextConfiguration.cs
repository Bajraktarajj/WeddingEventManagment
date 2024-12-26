using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presistent;

namespace Service
{
    public static class DbContextConfiguration
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration) 
        {
            var connetionString = configuration.GetConnectionString("DatabaseConnetion");
            services.AddDbContext<WeedingEventManagmentDbContext>(options => options.UseSqlServer(connetionString));
        }
    }
}
