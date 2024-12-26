using Service;

var builder = WebApplication.CreateBuilder(args);
var _configuration = builder.Configuration;

builder.Services.RegisterDbContext(_configuration);
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.UseStaticFiles();

app.Run();
