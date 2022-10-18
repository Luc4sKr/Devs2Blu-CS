using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public Estado()
        {

        }

        public Estado(int id, String nome, String descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
