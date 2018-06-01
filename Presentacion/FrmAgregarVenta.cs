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
    public partial class FrmAgregarVenta : Form
    {
        public FrmAgregarVenta()
        {
            InitializeComponent();
        }

        private void PBoxMenu_Click(object sender, EventArgs e)
        {
            FrmVentas a = new FrmVentas();
            a.Show();
            this.Hide();
        }
    }
}
