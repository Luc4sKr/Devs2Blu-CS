using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.CadastroCarros.Models
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions<ContextDatabase> options) : base(options)
        {
            
        }
    }
}
