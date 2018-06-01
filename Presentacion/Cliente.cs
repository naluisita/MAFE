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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void PBoxAgregarCompras_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente a = new FrmAgregarCliente();
            a.Show();
            this.Hide();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmMenú a = new FrmMenú();
            a.Show();
            this.Hide();
        }
    }
}
