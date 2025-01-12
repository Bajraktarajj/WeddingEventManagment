using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using Service.Services;
using Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Read configuration from appsettings.json
var _configuration = builder.Configuration;

// Register DbContext directly with the correct connection string
builder.Services.AddDbContext<WeedingEventManagmentDbContext>(options =>
    options.UseSqlServer(_configuration.GetConnectionString("DatabaseConnection")));

// Add controllers and Razor Pages
builder.Services.AddControllers();
builder.Services.AddRazorPages();
// Register custom services directly
builder.Services.AddScoped<IWeddingService, WeddingService>();
builder.Services.AddScoped<IContactService, ContactService>();

var app = builder.Build();

// Middleware and routing setup
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();
