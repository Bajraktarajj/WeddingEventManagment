using Microsoft.EntityFrameworkCore;
using Presistent;
using Service.Interfaces;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

var _configuration = builder.Configuration;

builder.Services.AddDbContext<WeedingEventManagmentDbContext>(options =>
    options.UseSqlServer(_configuration.GetConnectionString("DatabaseConnection")));

builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//    c.SwaggerDoc("v1", new OpenApiInfo {  Title = "WeddingApp", Version = "v1" }));

//builder.Services.RegisterDbContext(_configuration);
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

//app.MapDefaultControllerRoute();
//app.UseSwagger();
//app.UseSwaggerUI();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("/", async context =>
//    {
//        context.Response.Redirect("/swagger", permanent: false);
//        await Task.CompletedTask;
//    });

//    endpoints.MapControllers();
//});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();
