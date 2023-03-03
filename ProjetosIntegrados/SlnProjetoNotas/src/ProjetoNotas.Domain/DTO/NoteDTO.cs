using ProjetoNotas.Domain.Entities;
using ProjetoNotas.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.DTO
{
    public class NoteDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public bool Fixed { get; set; }
        public DateTime TimeNote { get; set; }

        public int UserId { get; set; }
        public virtual UserDTO? User { get; set; }

        public Note MapToEntity()
        {
            return new Note
            {
                Id = this.Id,
                Title = this.Title,
                Description = this.Description,
                Category = this.Category,
                Fixed = this.Fixed,
                TimeNote = this.TimeNote,
                UserId = this.UserId
            };
        }

        public NoteDTO MapToDTO(NoteDTO noteDTO)
        {
            return new NoteDTO
            {
                Id = noteDTO.Id,
                Title = noteDTO.Title,
                Description = noteDTO.Description,
                Category = noteDTO.Category,
                Fixed = noteDTO.Fixed,
                TimeNote = noteDTO.TimeNote,
                UserId = noteDTO.UserId
            };
        }
    }
}
