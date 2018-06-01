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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmMenú a = new FrmMenú();
            a.Show();
            this.Hide();
        }

        private void PBoxAgregarCompras_Click(object sender, EventArgs e)
        {
            FrmAgregarCompras a = new FrmAgregarCompras();
            a.Show();
            this.Hide();
        }

        private void PBoxConsultarVenta_Click(object sender, EventArgs e)
        {
            FrmConsultarCompras a = new FrmConsultarCompras();
            a.Show();
            this.Hide();
        }
    }
}
