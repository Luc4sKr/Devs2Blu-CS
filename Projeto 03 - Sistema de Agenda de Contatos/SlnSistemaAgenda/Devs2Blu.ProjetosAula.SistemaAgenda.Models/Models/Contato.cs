using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Contato
    {
        public int Id_contato { get; set; }
        public Estado Estado { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Numero_tel { get; set; }

        public Contato()
        {

        }

        public Contato(int id_contato, Estado estado, string nome, string email, string numero_tel)
        {
            Id_contato = id_contato;
            Estado = estado;
            Nome = nome;
            Email = email;
            Numero_tel = numero_tel;
        }
    }
}
