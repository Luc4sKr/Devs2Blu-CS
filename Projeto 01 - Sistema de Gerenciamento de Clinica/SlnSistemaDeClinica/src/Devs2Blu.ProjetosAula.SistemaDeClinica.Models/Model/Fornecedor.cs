using Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaDeClinica.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 CodigoFornecedor { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            this.TipoPessoa = TipoPessoa.PJ;
        }

        public Fornecedor(Int32 codigo, String nome, String cpf, String tipoFornecedor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CGCCPF = cpf;
            this.TipoPessoa = TipoPessoa.PJ;
            this.TipoFornecedor = tipoFornecedor;

            Random random = new Random();
            this.CodigoFornecedor = Int32.Parse($"{codigo}{random.Next(3000, 3999)}");
        }
    }
}
