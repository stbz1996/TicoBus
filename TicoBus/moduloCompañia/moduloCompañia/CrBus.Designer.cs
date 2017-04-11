namespace moduloCompañia
{
    partial class CrBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrBus));
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.txtCedulaJuridica = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.crearEmpresa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.iniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iniciarSesion.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iniciarSesion.ForeColor = System.Drawing.Color.MintCream;
            this.iniciarSesion.Location = new System.Drawing.Point(261, 303);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(155, 37);
            this.iniciarSesion.TabIndex = 0;
            this.iniciarSesion.Text = "Iniciar Sesión";
            this.iniciarSesion.UseVisualStyleBackColor = false;
            this.iniciarSesion.Click += new System.EventHandler(this.iniciarSesion_Click);
            // 
            // txtCedulaJuridica
            // 
            this.txtCedulaJuridica.BackColor = System.Drawing.Color.DimGray;
            this.txtCedulaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaJuridica.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaJuridica.ForeColor = System.Drawing.Color.White;
            this.txtCedulaJuridica.Location = new System.Drawing.Point(261, 180);
            this.txtCedulaJuridica.Name = "txtCedulaJuridica";
            this.txtCedulaJuridica.Size = new System.Drawing.Size(155, 29);
            this.txtCedulaJuridica.TabIndex = 1;
            this.txtCedulaJuridica.Text = "Cedula Juridica";
            this.txtCedulaJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedulaJuridica.Click += new System.EventHandler(this.txtCedulaJuridica_Click);
            this.txtCedulaJuridica.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DimGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(261, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // crearEmpresa
            // 
            this.crearEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.crearEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crearEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crearEmpresa.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearEmpresa.ForeColor = System.Drawing.Color.MintCream;
            this.crearEmpresa.Location = new System.Drawing.Point(261, 375);
            this.crearEmpresa.Name = "crearEmpresa";
            this.crearEmpresa.Size = new System.Drawing.Size(155, 37);
            this.crearEmpresa.TabIndex = 3;
            this.crearEmpresa.Text = "Crear Empresa";
            this.crearEmpresa.UseVisualStyleBackColor = false;
            this.crearEmpresa.Click += new System.EventHandler(this.crearEmpresa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CrBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::moduloCompañia.Properties.Resources._12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crearEmpresa);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCedulaJuridica);
            this.Controls.Add(this.iniciarSesion);
            this.Name = "CrBus";
            this.Text = "CrBus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarSesion;
        private System.Windows.Forms.TextBox txtCedulaJuridica;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button crearEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

