using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sorvetures
{
    public class Conexao
    {
        private static string connectionString = "Server=localhost;Port=3306;Database=dbsorvetures;Uid=root;Pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connectionString);
            try
            {

                conn.Open();

                return conn;
            }
            catch (SqlException)
            {
                return null;
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
