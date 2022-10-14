using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class EnderecoRepository : IRepository
    {
        #region FACADE
        public MySqlDataReader FetchAll()
        {
            return FetchAllEndereco();
        }

        public void Save()
        {
            SaveEndereco();
        }
        #endregion

        private MySqlDataReader FetchAllEndereco()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ENDERECO, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SaveEndereco()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, connection);

                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = FormCadastro.EnderecoCompromisso.Cep;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = FormCadastro.EnderecoCompromisso.Uf;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = FormCadastro.EnderecoCompromisso.Cidade;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = FormCadastro.EnderecoCompromisso.Bairro;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = FormCadastro.EnderecoCompromisso.Rua;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = FormCadastro.EnderecoCompromisso.Numero;

                cmd.ExecuteNonQuery();

                FormCadastro.EnderecoCompromisso.Id = (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQL's
        private const String SQL_SELECT_ENDERECO = "SELECT * FROM endereco";

        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
                                                    (cep,
                                                    uf,
                                                    cidade,
                                                    bairro,
                                                    rua,
                                                    numero)
                                                    VALUES
                                                    (@cep,
                                                    @uf,
                                                    @cidade,
                                                    @bairro,
                                                    @rua,
                                                    @numero)";
        #endregion
    }
}
