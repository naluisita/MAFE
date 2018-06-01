namespace Presentacion
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PgBar = new System.Windows.Forms.ProgressBar();
            this.TimerLoading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PgBar
            // 
            this.PgBar.Location = new System.Drawing.Point(163, 186);
            this.PgBar.Name = "PgBar";
            this.PgBar.Size = new System.Drawing.Size(179, 32);
            this.PgBar.TabIndex = 0;
            this.PgBar.Click += new System.EventHandler(this.PgBar_Click);
            // 
            // TimerLoading
            // 
            this.TimerLoading.Enabled = true;
            this.TimerLoading.Interval = 1000;
            this.TimerLoading.Tick += new System.EventHandler(this.TimerLoading_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.MAFE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 407);
            this.Controls.Add(this.PgBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PgBar;
        private System.Windows.Forms.Timer TimerLoading;
    }
}

