using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class ContatoRepository : IRepository
    {
        #region FACADE
        public MySqlDataReader FetchAll()
        {
            return FetchAllContato();
        }

        public void Save()
        {
            SaveContato();
        }
        #endregion

        private MySqlDataReader FetchAllContato()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONTATO, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SaveContato()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONTATO, connection);

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = FormCadastro.Contato.Nome;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 45).Value = FormCadastro.Contato.Email;
                cmd.Parameters.Add("@numero_tel", MySqlDbType.VarChar, 20).Value = FormCadastro.Contato.Numero_tel;
                cmd.Parameters.Add("@flstatus", MySqlDbType.Enum).Value = EnumFlstatus.A;

                cmd.ExecuteNonQuery();

                FormCadastro.Contato.Id = (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQL's
        private const String SQL_SELECT_CONTATO = "SELECT * FROM contato";

        private const String SQL_INSERT_CONTATO = @"INSERT INTO contato
                                                    (nome,
                                                    email,
                                                    numero_tel,
                                                    flstatus)
                                                    VALUES
                                                    (@nome,
                                                    @email,
                                                    @numero_tel,
                                                    @flstatus)";
        #endregion
    }
}
