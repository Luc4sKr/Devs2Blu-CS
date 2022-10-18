using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class CompromissoRepository : BaseRepository
    {
        public ContatoRepository ContatoRepository { get; set; }
        public EnderecoRepository EnderecoRepository { get; set; }

        public CompromissoRepository() : base("compromisso")
        {
            ContatoRepository = new ContatoRepository();
            EnderecoRepository = new EnderecoRepository();
        }

        public new Compromisso FindById(int id)
        {
            Compromisso compromisso = new Compromisso();
            var r = base.FindById(id);
            while(r.Read())
            {
                compromisso = new Compromisso(
                    r.GetInt32("id"),
                    ContatoRepository.FindById(r.GetInt32("id_contato")),
                    EnderecoRepository.FindById(r.GetInt32("id_endereco")),
                    r.GetString("titulo"),
                    r.GetString("descricao"),
                    r.GetString("dia_semana"),
                    r.GetDateTime("data_inicio"),
                    r.GetDateTime("data_fim"),
                    GetStatus(r.GetString("flstatus")));
            }

            return compromisso;
        }
    }
}
