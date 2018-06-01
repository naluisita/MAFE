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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            if (PgBar.Value < 100)
            {
                PgBar.Value = PgBar.Value + 10;
                //LblBarraCarga.Text = "Cargando el sistema (" + PgBar + "%)";
            }
            else
            {
                TimerLoading.Enabled = false;
                this.Hide();
                FrmLogin frmIni = new FrmLogin();
                frmIni.Show();
            }

        }

        private void PgBar_Click(object sender, EventArgs e)
        {

        }
    }
}
