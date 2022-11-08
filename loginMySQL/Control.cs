using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace loginMySQL
{
    internal class Control
    {
        public string ctrlRegistro(Usuarios user)
        {
            Modelo modelo = new Modelo();
            string res = "";

            if (string.IsNullOrEmpty(user.User) || string.IsNullOrEmpty(user.Password) 
             || string.IsNullOrEmpty(user.ConPassword))
            {
                res = "Debe de llenar todos los campos";
            }
            else
            {
                if (user.Password == user.ConPassword)
                {
                    if (modelo.existUsuario(user.User))
                    {
                        res = "El usuario ya existe";
                    }
                    else
                    {
                        user.Password = generarSHA1(user.Password);
                        modelo.registro(user);
                    }
                }
                else
                {
                    res = "Las contraseñas no coinciden";
                }
            }

            return res;
        }

        public string ctrlLogin(string User, string Password)
        {
            Modelo modelo = new Modelo();
            string res = "";
            Usuarios datoUser = null;

            if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
            {
                res = "Debe de llener todos los campos";
            }
            else
            {
                datoUser = modelo.porUsuario(User);

                if (datoUser == null)
                {
                    res = "El usuario no existe";
                }
                else
                {
                    if (datoUser.Password != generarSHA1(Password))
                    {
                        res = "El usuario y/o contraseña no coinciden";
                    }
                }
            }
            return res;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[ ] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }

    }
}
