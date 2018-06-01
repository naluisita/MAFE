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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void PBoxProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores a = new FrmProveedores();
            a.Show();
            this.Hide();
        }

        private void PBoxUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios a = new FrmUsuarios();
            a.Show();
            this.Hide();
        }

        private void PBoxCompras_Click(object sender, EventArgs e)
        {
            FrmCompras a = new FrmCompras();
            a.Show();
            this.Hide();
        }

        private void PBoxVentas_Click(object sender, EventArgs e)
        {
            FrmVentas a = new FrmVentas();
            a.Show();
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin a = new FrmLogin();
            a.Show();
            this.Hide();
        }

        private void PBoxArchivo_Click(object sender, EventArgs e)
        {
            FrmArchivo a = new FrmArchivo();
            a.Show();
            this.Hide();
        }

        private void PBoxProductos_Click(object sender, EventArgs e)
        {
            Productos a = new Productos();
            a.Show();
            this.Hide();
        }

        private void BtnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
