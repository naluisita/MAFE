namespace Presentacion
{
    partial class IniciarSesion
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
            this.PBoxLogin = new System.Windows.Forms.PictureBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxLogin
            // 
            this.PBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
//            this.PBoxLogin.Image = global::Presentacion.Properties.Resources.Login;
            this.PBoxLogin.Location = new System.Drawing.Point(49, 280);
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
            this.TxtContrasena.TextChanged += new System.EventHandler(this.TxtContrasena_TextChanged);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = global::Presentacion.Properties.Resources.Iniciosesion2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 426);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.PBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxLogin;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtContrasena;
    }
}