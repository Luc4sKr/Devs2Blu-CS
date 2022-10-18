using Devs2Blu.ProjetosAula.SistemaAgenda.Models.Enum;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaAgenda.Forms.Data
{
    public abstract class BaseRepository
    {
        public string Table { get; set; }

        public BaseRepository(string table)
        {
            Table = table;
        }

        public EnumFlstatus GetStatus(string status)
        {
            if (status.Equals(EnumFlstatus.I))
            {
                return EnumFlstatus.I;
            }
            if (status.Equals(EnumFlstatus.A))
            {
                return EnumFlstatus.A;
            }
            if (status.Equals(EnumFlstatus.C))
            {
                return EnumFlstatus.C;
            }
            if (status.Equals(EnumFlstatus.R))
            {
                return EnumFlstatus.R;
            }
            return EnumFlstatus.A;
        }

        #region Executes
        public MySqlDataReader GetAll()
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_ALL.Replace("@TABLE", Table), conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public MySqlDataReader FindById(int id)
        {
            string sqlFind = SQL_FIND_BY_ID.Replace("@TABLE", Table)
                                            .Replace("@ID", id.ToString());
            return Get(sqlFind);
        }

        public MySqlDataReader Get(string sqlGet)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlGet, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public int Insert(string columns, string values)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                string sqlInsert = SQL_INSERT.Replace("@TABLE", Table)
                                                .Replace("@COLUMNS", columns)
                                                .Replace("@VALUES", values);
                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);
                cmd.ExecuteNonQuery();

                return (int)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public int Update(string columns, int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                string sqlInsert = SQL_UPDATE.Replace("@TABLE", Table)
                                                .Replace("@COLUMNS", columns);
                MySqlCommand cmd = new MySqlCommand(sqlInsert, conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
                return cmd.ExecuteNonQuery();

            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public bool DeleteById(int id)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_BY_ID.Replace("@TABLE", Table), conn);
                cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        #endregion


        #region SQLs
        private const string SQL_SELECT_ALL = @"SELECT * FROM @TABLE";
        private const string SQL_FIND_BY_ID = @"SELECT * FROM @TABLE WHERE id = @ID";
        private const string SQL_DELETE_BY_ID = @"DELETE FROM @TABLE WHERE id = @ID";
        private const string SQL_INSERT = @"INSERT INTO @TABLE (@COLUMNS) VALUES (@VALUES)";
        private const string SQL_UPDATE = @"UPDATE @TABLE SET @COLUMNS WHERE id = @ID";
        #endregion
    }
}
