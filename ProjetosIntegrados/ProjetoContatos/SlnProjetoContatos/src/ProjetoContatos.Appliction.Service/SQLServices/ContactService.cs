using ProjetoContatos.Domain.DTO;
using ProjetoContatos.Domain.Interfaces.IRepository;
using ProjetoContatos.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContatos.Appliction.Service.SQLServices
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public List<ContactDTO> FindAll()
        {
            return _contactRepository
                .FindAll()
                .Select(x => new ContactDTO
                {
                    id = x.Id,
                    name = x.Name,
                    phoneNumber = x.PhoneNumber,
                    email = x.Email
                }).ToList();
        }

        public Task<ContactDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(ContactDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ContactDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(ContactDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
