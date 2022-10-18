using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using System;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Compromisso
    {
        public int Id { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public String DiaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public EnumFlstatus FlStatus { get; set; }

        public Compromisso()
        {
            
        }

        public Compromisso(int id, Contato contato, Endereco endereco, string titulo, string descricao, String diaSemana, DateTime dataInicio, DateTime dataFim, EnumFlstatus flStatus)
        {
            Id = id;
            Contato = contato;
            Endereco = endereco;
            Titulo = titulo;
            Descricao = descricao;
            DiaSemana = diaSemana;
            DataInicio = dataInicio.Date;
            DataFim = dataFim.Date;
            FlStatus = flStatus;
        }
    }
}
