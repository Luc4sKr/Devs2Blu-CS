using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Recepcionista : Pessoa
    {
        public Int32 CodigoRecepcionista { get; set; }
        public String Setor { get; set; }

        public Recepcionista()
        {
            this.TipoPessoa = TipoPessoa.PF;
        }

        public Recepcionista(Int32 codigo, String nome, String cpf, String setor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CGCCPF = cpf;
            this.TipoPessoa = TipoPessoa.PF;
            this.Setor = setor;

            Random random = new Random();
            this.CodigoRecepcionista = Int32.Parse($"{codigo}{random.Next(10, 100)}");
        }
    }
}
