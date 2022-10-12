using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Numero_tel { get; set; }
        public EnumFlstatus FlStatus { get; set; }

        public Contato()
        {

        }

        public Contato(int id, string nome, string email, string numero_tel, EnumFlstatus flstatus)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Numero_tel = numero_tel;
            FlStatus = flstatus;
        }
    }
}
