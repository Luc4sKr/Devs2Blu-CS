using Devs2Blu.ProjetosAula.MVCSQL.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// EntityFramework
builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer($"Server=LAPTOP-K24VTQEH\\SQLEXPRESS;Database=AulaMVCFilme;User Id=sa;Password=admin;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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


// Criar migração
// Add-Migration Inicial-criacao -Context Context

// Atualizar database
// Update-Database