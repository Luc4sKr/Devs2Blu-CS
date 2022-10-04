using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Pessoa
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String CGCCPF { get; set; }
        public FlStatus Status { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public Pessoa()
        {
            Status = FlStatus.A;
        }

        public Pessoa(int id, string nome, string cGCCPF, FlStatus status, TipoPessoa tipoPessoa)
        {
            Id = id;
            Nome = nome;
            CGCCPF = cGCCPF;
            Status = status;
            TipoPessoa = tipoPessoa;
        }
    }
}
