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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmMenú a = new FrmMenú();
            a.Show();
            this.Hide();
        }

        private void PBoxConsultarVenta_Click(object sender, EventArgs e)
        {
            FrmConsultarVenta a = new FrmConsultarVenta();
            a.Show();
            this.Hide();
        }

        private void PBoxAgregarVenta_Click(object sender, EventArgs e)
        {
            FrmAgregarVenta a = new FrmAgregarVenta();
            a.Show();
            this.Hide();
          
        }
    }
}
