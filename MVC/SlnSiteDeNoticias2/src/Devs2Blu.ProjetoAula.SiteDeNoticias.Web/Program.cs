using Devs2Blu.ProjetoAula.SiteDeNoticias.Application.Services.SQLServerServices;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IRepositories;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.IServices;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Context;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer($"Server=LAPTOP-K24VTQEH\\SQLEXPRESS;Database=DB_NewsPage;User Id=sa;Password=admin; TrustServerCertificate=True;"));

// # Dependency Injection
// Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();

// Services
builder.Services.AddScoped<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
