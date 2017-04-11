namespace moduloCompañia
{
    partial class frmRutasFrecuentes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFiltrarFecha = new System.Windows.Forms.Button();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.labelRutas = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBoxEmpresas = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxEmpresas);
            this.panel1.Controls.Add(this.buttonFiltrarFecha);
            this.panel1.Controls.Add(this.dateTimeHasta);
            this.panel1.Controls.Add(this.dateTimeDesde);
            this.panel1.Controls.Add(this.labelRutas);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 761);
            this.panel1.TabIndex = 0;
            // 
            // buttonFiltrarFecha
            // 
            this.buttonFiltrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFiltrarFecha.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrarFecha.Location = new System.Drawing.Point(570, 10);
            this.buttonFiltrarFecha.Name = "buttonFiltrarFecha";
            this.buttonFiltrarFecha.Size = new System.Drawing.Size(116, 28);
            this.buttonFiltrarFecha.TabIndex = 6;
            this.buttonFiltrarFecha.Text = "Filtrar Fecha";
            this.buttonFiltrarFecha.UseVisualStyleBackColor = true;
            this.buttonFiltrarFecha.Click += new System.EventHandler(this.buttonFiltrarFecha_Click);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(469, 13);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(95, 20);
            this.dateTimeHasta.TabIndex = 5;
            this.dateTimeHasta.ValueChanged += new System.EventHandler(this.dateTimeHasta_ValueChanged);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(359, 13);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(95, 20);
            this.dateTimeDesde.TabIndex = 4;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // labelRutas
            // 
            this.labelRutas.AutoSize = true;
            this.labelRutas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutas.Location = new System.Drawing.Point(10, 12);
            this.labelRutas.Name = "labelRutas";
            this.labelRutas.Size = new System.Drawing.Size(146, 22);
            this.labelRutas.TabIndex = 2;
            this.labelRutas.Text = "Filtrar por empresa:";
            this.labelRutas.Click += new System.EventHandler(this.labelRutas_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 48);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(946, 713);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // comboBoxEmpresas
            // 
            this.comboBoxEmpresas.FormattingEnabled = true;
            this.comboBoxEmpresas.Location = new System.Drawing.Point(162, 15);
            this.comboBoxEmpresas.Name = "comboBoxEmpresas";
            this.comboBoxEmpresas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpresas.TabIndex = 14;
            this.comboBoxEmpresas.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpresas_SelectedIndexChanged);
            // 
            // frmRutasFrecuentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 761);
            this.Controls.Add(this.panel1);
            this.Name = "frmRutasFrecuentes";
            this.Text = "frmRutasFrecuentes";
            this.Load += new System.EventHandler(this.frmRutasFrecuentes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRutas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button buttonFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.ComboBox comboBoxEmpresas;
    }
}