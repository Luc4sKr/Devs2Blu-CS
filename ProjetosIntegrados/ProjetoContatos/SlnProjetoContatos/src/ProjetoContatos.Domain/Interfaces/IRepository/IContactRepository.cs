using ProjetoContatos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContatos.Domain.Interfaces.IRepository
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
    }
}
