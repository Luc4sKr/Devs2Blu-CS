using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class ContatoRepository : BaseRepository
    {
        public ContatoRepository() : base("contato")
        {

        }

        public new Contato FindById(int id)
        {
            Contato contato = new Contato();
            var r = base.FindById(id);
            while (r.Read())
            {
                contato = new Contato(
                    r.GetInt32("id"),
                    r.GetString("nome"),
                    r.GetString("email"),
                    r.GetString("numero_tel"),
                    GetStatus(r.GetString("flstatus")));
            }

            return contato;
        }
    }
}
