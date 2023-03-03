using Microsoft.EntityFrameworkCore;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Infra.Data.Repository.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasOne(note => note.User)
                .WithMany(user => user.Notes)
                .HasForeignKey(note => note.UserId);

            modelBuilder.Entity<User>()
                .HasData(
                    new { Id=1, Name="Lucas Kreuch", Login="Luc4sKr", Password="123"}
                );

            modelBuilder.Entity<Note>()
                .HasData(
                    new { Id=1, Title="Lorem", Description="Quisque velit nisi", Category=CategoryEnum.Notes, Fixed=true, TimeNote=DateTime.Now, UserId=1}
                );
        }

        #region DbSets<Tables>
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        #endregion
    }
}
