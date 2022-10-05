using System;
using System.ComponentModel;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Convenio
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public FlConvStatus Status { get; set; }
    
        public Convenio()
        {
            Status = FlConvStatus.A;
        }

        public Convenio(String nome)
        {
            Nome = nome;
            Status = FlConvStatus.A;
        }

        public Convenio(int id, string nome, FlConvStatus status)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }

     public enum FlConvStatus
    {
        [Description("Excluído")]
        I = 0,
        [Description("Ativo")]
        A = 1,
    }
}
