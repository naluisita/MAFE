using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void PBoxLogin_Click(object sender, EventArgs e)
        {
            if ((TxtUsername.Text != null && !string.IsNullOrWhiteSpace(TxtUsername.Text)) && (TxtContrasena.Text == "123"))
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("No se puede ingresar", "ERROR");
            }
        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
