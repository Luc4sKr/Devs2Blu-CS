using Devs2Blu.Cadastrojogos.Models;
using Devs2Blu.Cadastrojogos.Repository;
using Devs2Blu.Cadastrojogos.Services.Implements;
using Devs2Blu.Cadastrojogos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContextDatabase>
    (options => options.UseSqlServer($"Server=LAPTOP-K24VTQEH\\SQLEXPRESS;Database=CadastroJogos;User Id=sa;Password=admin; TrustServerCertificate=True;"));

// Repositories
builder.Services.AddScoped<EmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<JogoRepository, JogoRepository>();

// Services
builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IJogoService, JogoService>();

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
