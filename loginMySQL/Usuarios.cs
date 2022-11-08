using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginMySQL
{
    internal class Usuarios
    {
        int id;
        string user, password, conPassword;

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public int Id { get => id; set => id = value; }
    }
}
