using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public class CompromissoRepository : IRepository
    {
        #region FACADE
        public MySqlDataReader FetchAll()
        {
            return FetchAllCompromisso();
        }

        public void Save()
        {
            SaveCompromisso();
        }
        #endregion

        private MySqlDataReader FetchAllCompromisso()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_COMPROMISSO, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SaveCompromisso()
        {
            MySqlConnection connection = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_COMPROMISSO, connection);

                cmd.Parameters.Add("@id_contato", MySqlDbType.Int32).Value = FormCadastro.Compromisso.Contato.Id;
                cmd.Parameters.Add("@id_endereco", MySqlDbType.Int32).Value = FormCadastro.Compromisso.Endereco.Id;
                cmd.Parameters.Add("@titulo", MySqlDbType.VarChar, 45).Value = FormCadastro.Compromisso.Titulo;
                cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 255).Value = FormCadastro.Compromisso.Descricao;
                cmd.Parameters.Add("@dia_semana", MySqlDbType.Enum).Value = FormCadastro.Compromisso.DiaSemana;
                cmd.Parameters.Add("@data_inicio", MySqlDbType.DateTime).Value = FormCadastro.Compromisso.DataInicio;
                cmd.Parameters.Add("@data_fim", MySqlDbType.DateTime).Value = FormCadastro.Compromisso.DataFim;

                cmd.ExecuteNonQuery();

                FormCadastro.Compromisso.Id = (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private const String SQL_SELECT_COMPROMISSO = "SELECT * FROM compromisso";

        private const String SQL_INSERT_COMPROMISSO = @"INSERT INTO compromisso
                                                        (id_contato,
                                                        id_endereco,
                                                        titulo,
                                                        descricao,
                                                        dia_semana,
                                                        data_inicio,
                                                        data_fim)
                                                        VALUES
                                                        (@id_contato,
                                                        @id_endereco,
                                                        @titulo,
                                                        @descricao,
                                                        @dia_semana,
                                                        @data_inicio,
                                                        @data_fim)";
    }
}
