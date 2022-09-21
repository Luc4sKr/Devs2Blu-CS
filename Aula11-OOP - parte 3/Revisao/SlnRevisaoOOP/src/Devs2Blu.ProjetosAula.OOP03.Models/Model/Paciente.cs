using Devs2Blu.ProjetosAula.OOP03.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP03.Models.Model
{
    public class Paciente : Pessoa
    {
        public Int32 CodigoPaciente { get; set; }
        public String Convenio { get; set; }

        public Paciente()
        {
            this.TipoPessoa = TipoPessoa.PF;
        }

        public Paciente(Int32 codigo, String nome, String cpf, String convenio)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CGCCPF = cpf;
            this.TipoPessoa = TipoPessoa.PF;
            this.Convenio = convenio;

            Random random = new Random();
            this.CodigoPaciente = Int32.Parse($"{codigo}{random.Next(100, 999)}");
        }
    }
}
