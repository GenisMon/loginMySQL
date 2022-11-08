using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginMySQL
{
    internal class Modelo
    {
        public int registro(Usuarios user)
        {
            MySqlConnection conn = Conexion.GetConexion();
            conn.Open();

            string sql = "INSERT INTO usuarios (User, Password) VALUES(@User, @Password)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@User", user.User);
            cmd.Parameters.AddWithValue("@Password", user.Password);

            int resul = cmd.ExecuteNonQuery();

            return resul;
        }

        public bool existUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conn = Conexion.GetConexion();
            conn.Open();

            string sql = "SELECT IdLogin FROM usuarios WHERE User LIKE @User";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@User", usuario);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conn = Conexion.GetConexion();
            conn.Open();

            string sql = "SELECT IdLogin, User, Password FROM usuarios WHERE User LIKE @User";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@User", usuario);

            reader = cmd.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["IdLogin"].ToString());
                usr.Password = reader["Password"].ToString();
            }
            return usr;
        }
    }
}
