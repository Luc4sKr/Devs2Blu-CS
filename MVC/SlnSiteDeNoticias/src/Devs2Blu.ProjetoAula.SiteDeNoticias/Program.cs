using Devs2Blu.ProjetoAula.SiteDeNoticias.Models;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Repository;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Implements;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContextDatabase>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

// Repositories
builder.Services.AddScoped<NoticiaRepository, NoticiaRepository>();

// Services
builder.Services.AddScoped<INoticiaService, NoticiaService>();

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
