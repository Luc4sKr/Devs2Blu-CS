using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public static class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            Server = "localhost";
            DataBase = "sistemacadastro";
            User = "root";
            Password = "root";
            ConnectionString = $"Persist Security Info=False;server={Server};database={DataBase};uid={User};server={Server};database={DataBase};uid={User};pwd='{Password}'";

            var connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message, "Erro ao Conectar");
                throw;
            }

            return connection;
        }
    }
}
