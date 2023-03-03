using ProjetoContatos.Domain.Entities;
using ProjetoContatos.Domain.Interfaces.IRepository;
using ProjetoContatos.Infra.Data.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContatos.Infra.Data.Repository.Repositories
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
