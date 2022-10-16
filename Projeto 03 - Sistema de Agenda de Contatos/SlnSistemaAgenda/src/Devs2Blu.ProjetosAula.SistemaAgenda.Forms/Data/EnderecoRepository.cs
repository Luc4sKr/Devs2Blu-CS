using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Interfaces;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class EnderecoRepository : BaseRepository
    {
        public EnderecoRepository() : base("endereco")
        {

        }

        public new Endereco FindById(int id)
        {
            Endereco endereco = new Endereco();
            var r = base.FindById(id);
            while(r.Read())
            {
                endereco = new Endereco(
                    r.GetInt32("id"),
                    r.GetString("cep"),
                    r.GetString("uf"),
                    r.GetString("cidade"),
                    r.GetString("bairro"),
                    r.GetString("rua"),
                    r.GetInt32("numero"));
            }

            return endereco;
        }
    }
}
