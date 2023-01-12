using Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Mapeamento de Relacionamento
            modelBuilder.Entity<Noticia>()
                .HasOne(noticia => noticia.Categoria)
                .WithMany(categoria => categoria.Noticias)
                .HasForeignKey(noticia => noticia.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                    new { Id = 1, Nome = "Política"},
                    new { Id = 2, Nome = "Esportes" },
                    new { Id = 3, Nome = "Entretenimento" },
                    new { Id = 4, Nome = "Brasil" }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Noticia> Noticia { get; set; }
        #endregion
    }
}
