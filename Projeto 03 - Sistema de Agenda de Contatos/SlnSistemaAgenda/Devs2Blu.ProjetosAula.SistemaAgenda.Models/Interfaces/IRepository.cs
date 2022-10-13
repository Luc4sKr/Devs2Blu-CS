using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Models;
using MySql.Data.MySqlClient;
using System;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Models.Interfaces
{
    public interface IRepository
    {
        MySqlDataReader FetchAll();
        void Save();
    }
}
