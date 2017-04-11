namespace moduloCompañia
{
    partial class frmHistorialTarifa
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
            this.labelRutas = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBoxRutaA = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxRutaA);
            this.panel1.Controls.Add(this.labelRutas);
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 761);
            this.panel1.TabIndex = 0;
            // 
            // labelRutas
            // 
            this.labelRutas.AutoSize = true;
            this.labelRutas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutas.Location = new System.Drawing.Point(10, 12);
            this.labelRutas.Name = "labelRutas";
            this.labelRutas.Size = new System.Drawing.Size(121, 22);
            this.labelRutas.TabIndex = 2;
            this.labelRutas.Text = "Filtrar por ruta:";
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
            // comboBoxRutaA
            // 
            this.comboBoxRutaA.FormattingEnabled = true;
            this.comboBoxRutaA.Location = new System.Drawing.Point(137, 15);
            this.comboBoxRutaA.Name = "comboBoxRutaA";
            this.comboBoxRutaA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRutaA.TabIndex = 17;
            this.comboBoxRutaA.SelectedIndexChanged += new System.EventHandler(this.comboBoxRutaA_SelectedIndexChanged);
            // 
            // frmHistorialTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 761);
            this.Controls.Add(this.panel1);
            this.Name = "frmHistorialTarifa";
            this.Text = "frmHistorialTarifa";
            this.Load += new System.EventHandler(this.frmHistorialTarifa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRutas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBoxRutaA;
    }
}