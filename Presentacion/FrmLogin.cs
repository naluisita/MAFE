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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void PBoxLogin_Click(object sender, EventArgs e)
        {
            string username;
            string contrasena;
            string typeusername;

            username = TxtUsername.Text;
            contrasena = TxtContrasena.Text;
            typeusername = CmbCargo.Text;

            if (username == "Gerente" && contrasena == "123" && typeusername == "Gerente")
            {
                MessageBox.Show("Bienvenido al programa", "GERENTE");
                this.Hide();
                FrmMenú a = new FrmMenú();
                a.Show();
            }
            else if (username == "Auxiliar" && contrasena == "321" && typeusername == "Auxiliar")
            {
                MessageBox.Show("Bienvenido al programa", "AUXILIAR");
                this.Hide();
                FrmMenú a = new FrmMenú();
                a.Show();
                a.PBoxUsuarios.Enabled = false;
                a.PBoxUsuarios.Visible = false;
            }
            else
            {  MessageBox.Show("Información invalida, vuelva a ingresar los datos", "ERROR");
                TxtUsername.Clear();
                TxtContrasena.Clear();
                TxtUsername.Focus();
                CmbCargo.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
