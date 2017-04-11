namespace moduloCompañia
{
    partial class agregarRutasyBuses
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agregarAutobus = new System.Windows.Forms.Button();
            this.listaBuses = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarRuta = new System.Windows.Forms.Button();
            this.listaRutas = new System.Windows.Forms.ListBox();
            this.finalizar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.agregarAutobus);
            this.groupBox2.Controls.Add(this.listaBuses);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autobuses";
            // 
            // agregarAutobus
            // 
            this.agregarAutobus.BackColor = System.Drawing.Color.Transparent;
            this.agregarAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarAutobus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarAutobus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarAutobus.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarAutobus.ForeColor = System.Drawing.Color.MintCream;
            this.agregarAutobus.Location = new System.Drawing.Point(210, 71);
            this.agregarAutobus.Name = "agregarAutobus";
            this.agregarAutobus.Size = new System.Drawing.Size(150, 40);
            this.agregarAutobus.TabIndex = 1;
            this.agregarAutobus.Text = "Agregar Autobus";
            this.agregarAutobus.UseVisualStyleBackColor = false;
            this.agregarAutobus.Click += new System.EventHandler(this.agregarAutobus_Click);
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.agregarRuta);
            this.groupBox1.Controls.Add(this.listaRutas);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutas de la Empresa";
            // 
            // agregarRuta
            // 
            this.agregarRuta.BackColor = System.Drawing.Color.Transparent;
            this.agregarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregarRuta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.agregarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarRuta.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarRuta.ForeColor = System.Drawing.Color.MintCream;
            this.agregarRuta.Location = new System.Drawing.Point(233, 71);
            this.agregarRuta.Name = "agregarRuta";
            this.agregarRuta.Size = new System.Drawing.Size(127, 37);
            this.agregarRuta.TabIndex = 1;
            this.agregarRuta.Text = "Agregar Ruta";
            this.agregarRuta.UseVisualStyleBackColor = false;
            this.agregarRuta.Click += new System.EventHandler(this.agregarRuta_Click_1);
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
            this.listaRutas.Size = new System.Drawing.Size(160, 134);
            this.listaRutas.TabIndex = 0;
            // 
            // finalizar
            // 
            this.finalizar.BackColor = System.Drawing.Color.Transparent;
            this.finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.finalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalizar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.MintCream;
            this.finalizar.Location = new System.Drawing.Point(453, 336);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(150, 40);
            this.finalizar.TabIndex = 5;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = false;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // agregarRutasyBuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::moduloCompañia.Properties.Resources._12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 435);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "agregarRutasyBuses";
            this.Text = "agregarRutasyBuses";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button agregarAutobus;
        private System.Windows.Forms.ListBox listaBuses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button agregarRuta;
        private System.Windows.Forms.ListBox listaRutas;
        private System.Windows.Forms.Button finalizar;
    }
}