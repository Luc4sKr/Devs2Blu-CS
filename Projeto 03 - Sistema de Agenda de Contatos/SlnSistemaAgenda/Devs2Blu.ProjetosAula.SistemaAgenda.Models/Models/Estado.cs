using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Estado
    {
        public int Id_estado { get; set; }
        public String Nome { get; set; }

        public Estado()
        {

        }

        public Estado(int id, String nome)
        {
            Id_estado = id;
            Nome = nome;
        }
    }
}
