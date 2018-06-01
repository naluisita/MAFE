namespace Presentacion
{
    partial class FrmConsultarUsuario
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
            this.PBoxLinea = new System.Windows.Forms.PictureBox();
            this.PBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblCompras = new System.Windows.Forms.Label();
            this.LblAtras = new System.Windows.Forms.Label();
            this.PBoxMenu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGerente = new System.Windows.Forms.Button();
            this.BtnAuxiliar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxLinea
            // 
            this.PBoxLinea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PBoxLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxLinea.ErrorImage = null;
            this.PBoxLinea.Location = new System.Drawing.Point(290, -7);
            this.PBoxLinea.Name = "PBoxLinea";
            this.PBoxLinea.Size = new System.Drawing.Size(16, 501);
            this.PBoxLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLinea.TabIndex = 6;
            this.PBoxLinea.TabStop = false;
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.Image = global::Presentacion.Properties.Resources.MAFE;
            this.PBoxLogo.Location = new System.Drawing.Point(24, 254);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(244, 185);
            this.PBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogo.TabIndex = 5;
            this.PBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Proveedores;
            this.pictureBox1.Location = new System.Drawing.Point(149, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // LblCompras
            // 
            this.LblCompras.AutoSize = true;
            this.LblCompras.BackColor = System.Drawing.Color.Transparent;
            this.LblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCompras.Location = new System.Drawing.Point(149, 182);
            this.LblCompras.Name = "LblCompras";
            this.LblCompras.Size = new System.Drawing.Size(113, 24);
            this.LblCompras.TabIndex = 41;
            this.LblCompras.Text = "USUARIOS";
            // 
            // LblAtras
            // 
            this.LblAtras.AutoSize = true;
            this.LblAtras.BackColor = System.Drawing.Color.Transparent;
            this.LblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAtras.Location = new System.Drawing.Point(47, 182);
            this.LblAtras.Name = "LblAtras";
            this.LblAtras.Size = new System.Drawing.Size(78, 24);
            this.LblAtras.TabIndex = 40;
            this.LblAtras.Text = "ATRÁS";
            // 
            // PBoxMenu
            // 
            this.PBoxMenu.Image = global::Presentacion.Properties.Resources.flecha_hacia_atras_esbozar_318_8503;
            this.PBoxMenu.Location = new System.Drawing.Point(24, 62);
            this.PBoxMenu.Name = "PBoxMenu";
            this.PBoxMenu.Size = new System.Drawing.Size(119, 117);
            this.PBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxMenu.TabIndex = 39;
            this.PBoxMenu.TabStop = false;
            this.PBoxMenu.Click += new System.EventHandler(this.PBoxMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(358, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 55;
            this.label4.Text = "SELECCIONE TIPO DE USUARIO";
            // 
            // BtnGerente
            // 
            this.BtnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerente.Location = new System.Drawing.Point(362, 226);
            this.BtnGerente.Name = "BtnGerente";
            this.BtnGerente.Size = new System.Drawing.Size(135, 104);
            this.BtnGerente.TabIndex = 56;
            this.BtnGerente.Text = "GERENTE";
            this.BtnGerente.UseVisualStyleBackColor = true;
            this.BtnGerente.Click += new System.EventHandler(this.BtnGerente_Click);
            // 
            // BtnAuxiliar
            // 
            this.BtnAuxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAuxiliar.Location = new System.Drawing.Point(546, 226);
            this.BtnAuxiliar.Name = "BtnAuxiliar";
            this.BtnAuxiliar.Size = new System.Drawing.Size(135, 104);
            this.BtnAuxiliar.TabIndex = 57;
            this.BtnAuxiliar.Text = "AUXILIAR";
            this.BtnAuxiliar.UseVisualStyleBackColor = true;
            this.BtnAuxiliar.Click += new System.EventHandler(this.BtnAuxiliar_Click);
            // 
            // FrmConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo_café;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 489);
            this.Controls.Add(this.BtnAuxiliar);
            this.Controls.Add(this.BtnGerente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCompras);
            this.Controls.Add(this.LblAtras);
            this.Controls.Add(this.PBoxMenu);
            this.Controls.Add(this.PBoxLinea);
            this.Controls.Add(this.PBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBoxLinea;
        private System.Windows.Forms.PictureBox PBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblCompras;
        private System.Windows.Forms.Label LblAtras;
        private System.Windows.Forms.PictureBox PBoxMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGerente;
        private System.Windows.Forms.Button BtnAuxiliar;
    }
}