using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.AulaClasses
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }

        public Recepcionista() { }
        public Recepcionista(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public string AgedarConsulta()
        {
            return $"Consulta agendada!";
        }
    }
}
