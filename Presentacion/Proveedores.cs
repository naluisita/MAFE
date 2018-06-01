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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
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
            FrmAgregarProveedores a = new FrmAgregarProveedores();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmConsultarProveedor a = new FrmConsultarProveedor();
            a.Show();
            this.Hide();
        }
    }
}
