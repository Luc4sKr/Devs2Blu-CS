using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                    new { Id = 1, Nome = "Alimentos não perecíveis" },
                    new { Id = 2, Nome = "Laicínios" },
                    new { Id = 3, Nome = "Limpeza" },
                    new { Id = 4, Nome = "Bebidas não alcoólicas" }
                );

            modelBuilder.Entity<Produto>()
                .HasData(
                    new { Id = 1, Nome = "Arroz", Preco = 10.00, Quantidade = 5, CategoriaId = 1},
                    new { Id = 2, Nome = "Feijão", Preco = 15.00, Quantidade = 15, CategoriaId = 1 },
                    new { Id = 3, Nome = "Queijo", Preco = 20.00, Quantidade = 20, CategoriaId = 2 },
                    new { Id = 4, Nome = "Iogurte", Preco = 10.00, Quantidade = 5, CategoriaId = 2 },
                    new { Id = 5, Nome = "Suco de Laranja 1L", Preco = 5.00, Quantidade = 5, CategoriaId = 4 },
                    new { Id = 6, Nome = "Coca-Cola 2L", Preco = 8.00, Quantidade = 30, CategoriaId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        #endregion
    }
}
