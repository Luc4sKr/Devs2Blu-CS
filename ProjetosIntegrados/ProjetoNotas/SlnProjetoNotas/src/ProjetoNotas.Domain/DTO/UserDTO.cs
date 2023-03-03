using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual ICollection<NoteDTO>? Notes { get; set; }

        public User MapToEntity()
        {
            return new User
            {
                Id = this.Id,
                Name = this.Name,
                Login = this.Login,
                Password = this.Password,
            };
        }

        public UserDTO MapToDTO(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Login = user.Login,
                Password = user.Password,
            };
        }
    }
}
