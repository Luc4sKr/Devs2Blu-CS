using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Paciente
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public String Convenio { get; set; }

        public Paciente()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PF;
        }
    }
}
