namespace Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PBoxLogin = new System.Windows.Forms.PictureBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmbCargo = new System.Windows.Forms.ComboBox();
            this.LblCargo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxLogin
            // 
            this.PBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBoxLogin.Image = global::Presentacion.Properties.Resources.Login;
            this.PBoxLogin.Location = new System.Drawing.Point(49, 352);
            this.PBoxLogin.Name = "PBoxLogin";
            this.PBoxLogin.Size = new System.Drawing.Size(365, 45);
            this.PBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBoxLogin.TabIndex = 0;
            this.PBoxLogin.TabStop = false;
            this.PBoxLogin.Click += new System.EventHandler(this.PBoxLogin_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUsername.Location = new System.Drawing.Point(212, 140);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(202, 13);
            this.TxtUsername.TabIndex = 1;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtContrasena.Location = new System.Drawing.Point(212, 218);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(202, 13);
            this.TxtContrasena.TabIndex = 2;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.xD;
            this.pictureBox2.Location = new System.Drawing.Point(28, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CmbCargo
            // 
            this.CmbCargo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CmbCargo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmbCargo.FormattingEnabled = true;
            this.CmbCargo.Items.AddRange(new object[] {
            "",
            "Gerente",
            "Auxiliar"});
            this.CmbCargo.Location = new System.Drawing.Point(212, 294);
            this.CmbCargo.Name = "CmbCargo";
            this.CmbCargo.Size = new System.Drawing.Size(202, 21);
            this.CmbCargo.TabIndex = 5;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LblCargo.Location = new System.Drawing.Point(103, 294);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(94, 18);
            this.LblCargo.TabIndex = 6;
            this.LblCargo.Text = "Occupation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(413, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblCargo);
            this.Controls.Add(this.CmbCargo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.PBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxLogin;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CmbCargo;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Button button1;
    }
}