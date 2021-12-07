using System;
using System.Data.SqlClient;

namespace Clientes
{
    public class conexao
    {

        SqlConnection conn = new SqlConnection();
        public string id;
        
        public conexao()
        {
            conn.ConnectionString = "Data Source=DESKTOP-AU4AD53;Initial Catalog=AlanS;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }



    }
}