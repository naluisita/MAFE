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
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmUsuarios a = new FrmUsuarios();
            a.Show();
            this.Hide();
        }

        private void LblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
