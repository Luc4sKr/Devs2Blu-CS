using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private readonly IUserRepository _userRepository;

        public NoteService(INoteRepository noteRepository,
                           IUserRepository userRepository)
        {
            _noteRepository = noteRepository;
            _userRepository = userRepository;
        }

        public List<NoteDTO> FindAll()
        {
            return _noteRepository
                .FindAll()
                .Select(n => new NoteDTO()
                {
                    Id = n.Id,
                    Title = n.Title,
                    Description = n.Description,
                    Category = n.Category,
                    Fixed = n.Fixed,
                    TimeNote = n.TimeNote,
                    UserId = n.UserId,
                    User = new UserDTO()
                    {
                        Id = n.User.Id,
                        Name = n.User.Name,
                        Login = n.User.Login,
                        Password = n.User.Password,
                        Notes = null
                    }
                }).ToList(); ;
        }

        public Task<NoteDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(NoteDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(NoteDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
