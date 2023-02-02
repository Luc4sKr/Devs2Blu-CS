using Devs2Blu.FirstApiAspNetCore.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.FirstApiAspNetCore.API.Models.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasData(
                    new { Id = 1, Name = "Lucas", Contact1 = "47988887777", Contact2 = "47922223333", Email = "lucas@gmail.com" },
                    new { Id = 2, Name = "Maria", Contact1 = "47988886777", Contact2 = "47922224333", Email = "maria@gmail.com" },
                    new { Id = 3, Name = "Rita", Contact1 = "47988885777", Contact2 = "47922221333", Email = "rita@gmail.com" }
                );
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
