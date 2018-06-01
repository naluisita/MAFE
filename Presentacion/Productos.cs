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
    public partial class Productos : Form
    {
        public Productos()
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
            FrmAgregarProducto a = new FrmAgregarProducto();
            a.Show();
            this.Hide();
        }

        private void PBoxConsultarVenta_Click(object sender, EventArgs e)
        {
            FrmConsultarProductos a = new FrmConsultarProductos();
            a.Show();
            this.Hide();
        }
    }
}
