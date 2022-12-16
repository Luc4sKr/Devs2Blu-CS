using Devs2Blu.CadastroCarros.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.CadastroCarros.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Carro>()
                .HasOne(carro => carro.Marca)
                .WithMany(categoria => categoria.Carros)
                .HasForeignKey(carro => carro.MarcaId);

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Marca> Marca { get; set; }
        #endregion
    }
}
