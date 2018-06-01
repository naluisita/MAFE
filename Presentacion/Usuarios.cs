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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmMenú a = new FrmMenú();
            a.Show();
            this.Hide();
        }

        private void PBoxAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario a = new FrmAgregarUsuario();
            a.Show();
            this.Hide();
        }

        private void PBoxConsultarUsuario_Click(object sender, EventArgs e)
        {
            FrmConsultarUsuario a = new FrmConsultarUsuario();
            a.Show();
            this.Hide();
        }
    }
}
