using ProjetoContatos.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContatos.Domain.Interfaces.IService
{
    public interface IContactService
    {
        List<ContactDTO> FindAll();
        Task<ContactDTO> FindById(int id);
        Task<int> Save(ContactDTO entity);
        Task<int> Update(ContactDTO entity);
        Task<int> Delete(ContactDTO entity);
    }
}
