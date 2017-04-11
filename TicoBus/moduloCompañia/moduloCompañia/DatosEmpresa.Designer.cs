namespace moduloCompañia
{
    partial class DatosEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpresa));
            this.labelNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtCedulaJuridica = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agregarRuta = new System.Windows.Forms.Button();
            this.listaRutas = new System.Windows.Forms.ListBox();
            this.listaBuses = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.agregarAutobus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.MintCream;
            this.labelNombre.Location = new System.Drawing.Point(497, 159);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(75, 25);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuenta Bancaria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula Juridica:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonReportes);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCedulaJuridica);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empresa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.Color.Transparent;
            this.buttonReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReportes.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.MintCream;
            this.buttonReportes.Location = new System.Drawing.Point(238, 139);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(150, 40);
            this.buttonReportes.TabIndex = 9;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(68, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modificar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.DimGray;
            this.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuenta.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.ForeColor = System.Drawing.Color.White;
            this.txtCuenta.Location = new System.Drawing.Point(170, 88);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(155, 29);
            this.txtCuenta.TabIndex = 4;
            this.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCedulaJuridica
            // 
            this.txtCedulaJuridica.BackColor = System.Drawing.Color.DimGray;
            this.txtCedulaJuridica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaJuridica.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaJuridica.ForeColor = System.Drawing.Color.White;
            this.txtCedulaJuridica.Location = new System.Drawing.Point(170, 46);
            this.txtCedulaJuridica.Name = "txtCedulaJuridica";
            this.txtCedulaJuridica.ReadOnly = true;
            this.txtCedulaJuridica.Size = new System.Drawing.Size(155, 29);
            this.txtCedulaJuridica.TabIndex = 2;
            this.txtCedulaJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.agregarRuta);
            this.groupBox2.Controls.Add(this.listaRutas);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(351, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 181);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rutas de la Empresa";
            // 
            // agregarRuta
            // 
            this.agregarRuta.BackColor = System.Drawing.Color.Transparent;
            this.agregarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarRuta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarRuta.FlatAppearance.BorderSize = 3;
            this.agregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarRuta.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarRuta.ForeColor = System.Drawing.Color.MintCream;
            this.agregarRuta.Location = new System.Drawing.Point(165, 81);
            this.agregarRuta.Name = "agregarRuta";
            this.agregarRuta.Size = new System.Drawing.Size(127, 37);
            this.agregarRuta.TabIndex = 1;
            this.agregarRuta.Text = "Agregar";
            this.agregarRuta.UseVisualStyleBackColor = false;
            this.agregarRuta.Click += new System.EventHandler(this.agregarRuta_Click);
            // 
            // listaRutas
            // 
            this.listaRutas.BackColor = System.Drawing.Color.DimGray;
            this.listaRutas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaRutas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaRutas.ForeColor = System.Drawing.Color.MintCream;
            this.listaRutas.FormattingEnabled = true;
            this.listaRutas.ItemHeight = 22;
            this.listaRutas.Location = new System.Drawing.Point(18, 30);
            this.listaRutas.Name = "listaRutas";
            this.listaRutas.Size = new System.Drawing.Size(141, 134);
            this.listaRutas.TabIndex = 0;
            this.listaRutas.SelectedIndexChanged += new System.EventHandler(this.listaRutas_SelectedIndexChanged);
            // 
            // listaBuses
            // 
            this.listaBuses.BackColor = System.Drawing.Color.DimGray;
            this.listaBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaBuses.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaBuses.ForeColor = System.Drawing.Color.MintCream;
            this.listaBuses.FormattingEnabled = true;
            this.listaBuses.ItemHeight = 22;
            this.listaBuses.Location = new System.Drawing.Point(18, 30);
            this.listaBuses.Name = "listaBuses";
            this.listaBuses.Size = new System.Drawing.Size(121, 156);
            this.listaBuses.TabIndex = 0;
            this.listaBuses.SelectedIndexChanged += new System.EventHandler(this.listaBuses_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.agregarAutobus);
            this.groupBox3.Controls.Add(this.listaBuses);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox3.Location = new System.Drawing.Point(12, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 193);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Autobuses";
            // 
            // agregarAutobus
            // 
            this.agregarAutobus.BackColor = System.Drawing.Color.Transparent;
            this.agregarAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarAutobus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarAutobus.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAutobus.ForeColor = System.Drawing.Color.MintCream;
            this.agregarAutobus.Location = new System.Drawing.Point(180, 65);
            this.agregarAutobus.Name = "agregarAutobus";
            this.agregarAutobus.Size = new System.Drawing.Size(150, 40);
            this.agregarAutobus.TabIndex = 1;
            this.agregarAutobus.Text = "Agregar";
            this.agregarAutobus.UseVisualStyleBackColor = false;
            this.agregarAutobus.Click += new System.EventHandler(this.agregarAutobus_Click);
            // 
            // DatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::moduloCompañia.Properties.Resources._12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(665, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatosEmpresa";
            this.Text = "DatosEmpresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatosEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.DatosEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button agregarRuta;
        private System.Windows.Forms.ListBox listaRutas;
        private System.Windows.Forms.ListBox listaBuses;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button agregarAutobus;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtCedulaJuridica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReportes;
    }
}