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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.User = txtUser.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConPassword.Text;

            try
            {
                Control control = new Control();
                string res = control.ctrlRegistro(usuario);

                if (res.Length > 0)
                {
                    MessageBox.Show(res, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
