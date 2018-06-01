namespace Presentacion
{
    partial class FrmProveedores
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
            this.LblAtras = new System.Windows.Forms.Label();
            this.PBoxLinea = new System.Windows.Forms.PictureBox();
            this.PBoxLogo = new System.Windows.Forms.PictureBox();
            this.PBoxMenu = new System.Windows.Forms.PictureBox();
            this.PBoxAgregar = new System.Windows.Forms.PictureBox();
            this.LblCrearProveedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblConsultarProveedor = new System.Windows.Forms.Label();
            this.LblProveedores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAtras
            // 
            this.LblAtras.AutoSize = true;
            this.LblAtras.BackColor = System.Drawing.Color.Transparent;
            this.LblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAtras.Location = new System.Drawing.Point(54, 169);
            this.LblAtras.Name = "LblAtras";
            this.LblAtras.Size = new System.Drawing.Size(70, 24);
            this.LblAtras.TabIndex = 7;
            this.LblAtras.Text = "MENÚ";
            // 
            // PBoxLinea
            // 
            this.PBoxLinea.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PBoxLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxLinea.ErrorImage = null;
            this.PBoxLinea.Location = new System.Drawing.Point(290, -6);
            this.PBoxLinea.Name = "PBoxLinea";
            this.PBoxLinea.Size = new System.Drawing.Size(16, 501);
            this.PBoxLinea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLinea.TabIndex = 6;
            this.PBoxLinea.TabStop = false;
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.Image = global::Presentacion.Properties.Resources.MAFE;
            this.PBoxLogo.Location = new System.Drawing.Point(24, 232);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(244, 185);
            this.PBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogo.TabIndex = 5;
            this.PBoxLogo.TabStop = false;
            // 
            // PBoxMenu
            // 
            this.PBoxMenu.Image = global::Presentacion.Properties.Resources.flecha_hacia_atras_esbozar_318_8503;
            this.PBoxMenu.Location = new System.Drawing.Point(24, 52);
            this.PBoxMenu.Name = "PBoxMenu";
            this.PBoxMenu.Size = new System.Drawing.Size(119, 117);
            this.PBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxMenu.TabIndex = 4;
            this.PBoxMenu.TabStop = false;
            this.PBoxMenu.Click += new System.EventHandler(this.PBoxMenu_Click);
            // 
            // PBoxAgregar
            // 
            this.PBoxAgregar.BackColor = System.Drawing.Color.Transparent;
            this.PBoxAgregar.Image = global::Presentacion.Properties.Resources.suma_md;
            this.PBoxAgregar.Location = new System.Drawing.Point(458, 52);
            this.PBoxAgregar.Name = "PBoxAgregar";
            this.PBoxAgregar.Size = new System.Drawing.Size(118, 117);
            this.PBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxAgregar.TabIndex = 8;
            this.PBoxAgregar.TabStop = false;
            this.PBoxAgregar.Click += new System.EventHandler(this.PBoxAgregar_Click);
            // 
            // LblCrearProveedor
            // 
            this.LblCrearProveedor.AutoSize = true;
            this.LblCrearProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LblCrearProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrearProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCrearProveedor.Location = new System.Drawing.Point(420, 172);
            this.LblCrearProveedor.Name = "LblCrearProveedor";
            this.LblCrearProveedor.Size = new System.Drawing.Size(188, 20);
            this.LblCrearProveedor.TabIndex = 9;
            this.LblCrearProveedor.Text = "CREAR PROVEEDOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(458, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblConsultarProveedor
            // 
            this.LblConsultarProveedor.AutoSize = true;
            this.LblConsultarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LblConsultarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsultarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblConsultarProveedor.Location = new System.Drawing.Point(402, 397);
            this.LblConsultarProveedor.Name = "LblConsultarProveedor";
            this.LblConsultarProveedor.Size = new System.Drawing.Size(233, 20);
            this.LblConsultarProveedor.TabIndex = 11;
            this.LblConsultarProveedor.Text = "CONSULTAR PROVEEDOR";
            // 
            // LblProveedores
            // 
            this.LblProveedores.AutoSize = true;
            this.LblProveedores.BackColor = System.Drawing.Color.Transparent;
            this.LblProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProveedores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblProveedores.Location = new System.Drawing.Point(147, 174);
            this.LblProveedores.Name = "LblProveedores";
            this.LblProveedores.Size = new System.Drawing.Size(123, 16);
            this.LblProveedores.TabIndex = 12;
            this.LblProveedores.Text = "PROVEEDORES";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Proveedores;
            this.pictureBox2.Location = new System.Drawing.Point(149, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo_café;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 486);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblProveedores);
            this.Controls.Add(this.LblConsultarProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblCrearProveedor);
            this.Controls.Add(this.PBoxAgregar);
            this.Controls.Add(this.LblAtras);
            this.Controls.Add(this.PBoxLinea);
            this.Controls.Add(this.PBoxLogo);
            this.Controls.Add(this.PBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAtras;
        private System.Windows.Forms.PictureBox PBoxLinea;
        private System.Windows.Forms.PictureBox PBoxLogo;
        private System.Windows.Forms.PictureBox PBoxMenu;
        private System.Windows.Forms.PictureBox PBoxAgregar;
        private System.Windows.Forms.Label LblCrearProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblConsultarProveedor;
        private System.Windows.Forms.Label LblProveedores;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}