using ListaDeFilmesAPI.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListaDeFilmesAPI.API.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>()
                .HasData(
                    new { Id = 1, Titulo = "Deadpool 2", Descricao = "lorem", Rating = 10 },
                    new { Id = 2, Titulo = "Top Gun", Descricao = "lorem lorem", Rating = 10 },
                    new { Id = 3, Titulo = "Clube da Luta", Descricao = "lorem", Rating = 10 }
                );
        }

        public DbSet<Filme> Filme { get; set; }
    }
}
