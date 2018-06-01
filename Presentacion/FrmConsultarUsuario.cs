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
    public partial class FrmConsultarUsuario : Form
    {
        public FrmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmUsuarios a = new FrmUsuarios();
            a.Show();
            this.Hide();
        }

        private void BtnGerente_Click(object sender, EventArgs e)
        {
            FrmGerente a = new FrmGerente();
            a.Show();
            this.Hide();
        }

        private void BtnAuxiliar_Click(object sender, EventArgs e)
        {
            FrmAuxiliar a = new FrmAuxiliar();
            a.Show();
            this.Hide();
        }
    }
}
