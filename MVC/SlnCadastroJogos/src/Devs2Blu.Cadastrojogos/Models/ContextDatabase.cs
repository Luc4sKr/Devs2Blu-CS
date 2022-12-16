using Devs2Blu.Cadastrojogos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.Cadastrojogos.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Jogo>()
                .HasOne(jogo => jogo.Empresa)
                .WithMany(empresa => empresa.Jogos)
                .HasForeignKey(jogo => jogo.EmpresaId);

            // Seed
            modelBuilder.Entity<Empresa>()
                .HasData(
                    new { Id = 1, Nome = "Activision" },
                    new { Id = 2, Nome = " Rockstar Games" }
                );

            modelBuilder.Entity<Jogo>()
                .HasData(
                     new { Id = 1, Nome = "Call of Duty", Preco = 80.00, EmpresaId = 1 },
                     new { Id = 2, Nome = "Grand Theft Auto V", Preco = 100.00, EmpresaId = 2 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        #endregion
    }
}
