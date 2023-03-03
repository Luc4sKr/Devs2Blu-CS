using Microsoft.EntityFrameworkCore;
using ProjetoContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContatos.Infra.Data.Repository.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().
                HasData(
                    new { Id = 1, Name = "Lucas", PhoneNumber = "(47) 98888-7777", Email = "lucas@gmail.com" }
                );
        }

        #region DbSets
        public DbSet<Contact> Contacts { get; set; }
        #endregion
    }
}
