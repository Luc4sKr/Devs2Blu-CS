using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models
{
    public class Compromisso
    {
        public int Id { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
        public String Titulo { get; set; }
        public String Descricao { get; set; }
        public EnumDiaSemana DiaSemana { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public EnumFlstatus FlStatus { get; set; }

        public Compromisso()
        {
            
        }

        public Compromisso(int id, Contato contato, Endereco endereco, string titulo, string descricao, EnumDiaSemana diaSemana, DateTime dataInicio, DateTime dataFim, EnumFlstatus flStatus)
        {
            Id = id;
            Contato = contato;
            Endereco = endereco;
            Titulo = titulo;
            Descricao = descricao;
            DiaSemana = diaSemana;
            DataInicio = dataInicio;
            DataFim = dataFim;
            FlStatus = flStatus;
        }
    }
}
