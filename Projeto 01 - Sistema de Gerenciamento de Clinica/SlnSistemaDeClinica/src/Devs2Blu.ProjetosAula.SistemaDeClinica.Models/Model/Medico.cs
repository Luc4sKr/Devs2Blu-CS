using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model
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
