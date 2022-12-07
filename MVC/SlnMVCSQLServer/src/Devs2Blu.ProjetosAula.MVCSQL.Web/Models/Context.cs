using Devs2Blu.ProjetosAula.MVCSQL.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQL.Web.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }

        #region DbSets

        public DbSet<Filme> Filme { get; set; }

        #endregion
    }
}
