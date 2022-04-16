using EFDataAccess.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

IConfiguration Configuration = builder.Configuration;

builder.Services.AddDbContext<PeopleContext>(options =>
{
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
});
// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<RazorWebAppContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorWebAppContext") ?? throw new InvalidOperationException("Connection string 'RazorWebAppContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
