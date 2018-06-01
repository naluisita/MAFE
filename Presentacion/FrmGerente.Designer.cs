namespace Presentacion
{
    partial class FrmGerente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAtras = new System.Windows.Forms.Label();
            this.PBoxLinea = new System.Windows.Forms.PictureBox();
            this.PBoxLogo = new System.Windows.Forms.PictureBox();
            this.PBoxMenu = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PBox
            // 
            this.PBox.Image = global::Presentacion.Properties.Resources.Usuarios;
            this.PBox.Location = new System.Drawing.Point(160, 43);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(119, 117);
            this.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBox.TabIndex = 22;
            this.PBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(165, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "USUARIO";
            // 
            // LblAtras
            // 
            this.LblAtras.AutoSize = true;
            this.LblAtras.BackColor = System.Drawing.Color.Transparent;
            this.LblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAtras.Location = new System.Drawing.Point(58, 163);
            this.LblAtras.Name = "LblAtras";
            this.LblAtras.Size = new System.Drawing.Size(78, 24);
            this.LblAtras.TabIndex = 20;
            this.LblAtras.Text = "ATRÁS";
            // 
            // PBoxLinea
            // 
            this.PBoxLinea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PBoxLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxLinea.ErrorImage = null;
            this.PBoxLinea.Location = new System.Drawing.Point(300, -15);
            this.PBoxLinea.Name = "PBoxLinea";
            this.PBoxLinea.Size = new System.Drawing.Size(16, 501);
            this.PBoxLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLinea.TabIndex = 19;
            this.PBoxLinea.TabStop = false;
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.Image = global::Presentacion.Properties.Resources.MAFE;
            this.PBoxLogo.Location = new System.Drawing.Point(35, 226);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(244, 185);
            this.PBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogo.TabIndex = 18;
            this.PBoxLogo.TabStop = false;
            // 
            // PBoxMenu
            // 
            this.PBoxMenu.Image = global::Presentacion.Properties.Resources.flecha_hacia_atras_esbozar_318_8503;
            this.PBoxMenu.Location = new System.Drawing.Point(35, 43);
            this.PBoxMenu.Name = "PBoxMenu";
            this.PBoxMenu.Size = new System.Drawing.Size(119, 117);
            this.PBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxMenu.TabIndex = 17;
            this.PBoxMenu.TabStop = false;
            this.PBoxMenu.Click += new System.EventHandler(this.PBoxMenu_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Escriba aquí algunos datos relevantes de su cargo"});
            this.listBox1.Location = new System.Drawing.Point(369, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 351);
            this.listBox1.TabIndex = 23;
            // 
            // FrmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo_café;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 454);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAtras);
            this.Controls.Add(this.PBoxLinea);
            this.Controls.Add(this.PBoxLogo);
            this.Controls.Add(this.PBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerente";
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAtras;
        private System.Windows.Forms.PictureBox PBoxLinea;
        private System.Windows.Forms.PictureBox PBoxLogo;
        private System.Windows.Forms.PictureBox PBoxMenu;
        private System.Windows.Forms.ListBox listBox1;
    }
}