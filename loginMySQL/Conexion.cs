using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace loginMySQL
{
    internal class Conexion
    {
        public static MySqlConnection GetConexion()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string password = "12345678";
            string BD = "sistema";

            string conn = "Server = " + servidor + "; port = " + puerto + "; user id = " + usuario 
             + "; password =" + password + "; database =" + BD;

            MySqlConnection conexion = new MySqlConnection(conn);

            return conexion;
        }
    }
}
