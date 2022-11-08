using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginMySQL
{
    public partial class loginMySQL : Form
    {
        public loginMySQL()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registros rs = new Registros();
            this.Hide();
            rs.ShowDialog();
            this.Show();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contraseña = txtPassword.Text;

            try
            {
                Control ctrl = new Control();
                string res = ctrl.ctrlLogin(usuario, contraseña);
                if (res.Length > 0)
                {
                    MessageBox.Show(res,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Has ingresado correctamente","Bienvenido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
