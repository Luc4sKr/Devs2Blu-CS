using Devs2Blu.ProjetosAula.OOP03.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP03.Models.Model
{
    public class Medico : Pessoa
    {
        public Int32 CodigoMedico { get; set; }
        public Int32 CRM { get; set; }
        public String Especialidade { get; set; }

        public Medico()
        {
            this.TipoPessoa = TipoPessoa.PF;
        }

        public Medico(Int32 codigo, String nome, String cpf, Int32 crm, String especialidade)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CGCCPF = cpf;
            this.TipoPessoa = TipoPessoa.PF;
            this.Especialidade = especialidade;
            this.CRM = crm;

            Random random = new Random();
            this.CodigoMedico = Int32.Parse($"{codigo}{random.Next(10, 100)}");
        }
    }
}
