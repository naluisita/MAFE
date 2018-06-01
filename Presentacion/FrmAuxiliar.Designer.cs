namespace Presentacion
{
    partial class FrmAuxiliar
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
            this.BtnBuscarProveedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PBox
            // 
            this.PBox.Image = global::Presentacion.Properties.Resources.Usuarios;
            this.PBox.Location = new System.Drawing.Point(145, 49);
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
            this.label1.Location = new System.Drawing.Point(150, 169);
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
            this.LblAtras.Location = new System.Drawing.Point(43, 169);
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
            this.PBoxLinea.Location = new System.Drawing.Point(285, -9);
            this.PBoxLinea.Name = "PBoxLinea";
            this.PBoxLinea.Size = new System.Drawing.Size(16, 501);
            this.PBoxLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLinea.TabIndex = 19;
            this.PBoxLinea.TabStop = false;
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.Image = global::Presentacion.Properties.Resources.MAFE;
            this.PBoxLogo.Location = new System.Drawing.Point(20, 232);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(244, 185);
            this.PBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogo.TabIndex = 18;
            this.PBoxLogo.TabStop = false;
            // 
            // PBoxMenu
            // 
            this.PBoxMenu.Image = global::Presentacion.Properties.Resources.flecha_hacia_atras_esbozar_318_8503;
            this.PBoxMenu.Location = new System.Drawing.Point(20, 49);
            this.PBoxMenu.Name = "PBoxMenu";
            this.PBoxMenu.Size = new System.Drawing.Size(119, 117);
            this.PBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxMenu.TabIndex = 17;
            this.PBoxMenu.TabStop = false;
            this.PBoxMenu.Click += new System.EventHandler(this.PBoxMenu_Click);
            // 
            // BtnBuscarProveedor
            // 
            this.BtnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBuscarProveedor.Location = new System.Drawing.Point(442, 339);
            this.BtnBuscarProveedor.Name = "BtnBuscarProveedor";
            this.BtnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProveedor.TabIndex = 68;
            this.BtnBuscarProveedor.Text = "Buscar";
            this.BtnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(400, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ingrese dato de búsqueda:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 66;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Dirección",
            "E-mail",
            "Teléfono"});
            this.comboBox1.Location = new System.Drawing.Point(394, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(427, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "BUSCAR...";
            // 
            // FrmAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo_café;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 468);
            this.Controls.Add(this.BtnBuscarProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAtras);
            this.Controls.Add(this.PBoxLinea);
            this.Controls.Add(this.PBoxLogo);
            this.Controls.Add(this.PBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAuxiliar";
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
        private System.Windows.Forms.Button BtnBuscarProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}