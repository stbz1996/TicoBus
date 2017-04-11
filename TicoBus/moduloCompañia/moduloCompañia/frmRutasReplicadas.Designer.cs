namespace moduloCompañia
{
    partial class frmRutasReplicadas
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
            this.comboBoxRutaA = new System.Windows.Forms.ComboBox();
            this.labelRutas = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBoxRutaB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRutaA
            // 
            this.comboBoxRutaA.FormattingEnabled = true;
            this.comboBoxRutaA.Location = new System.Drawing.Point(81, 9);
            this.comboBoxRutaA.Name = "comboBoxRutaA";
            this.comboBoxRutaA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRutaA.TabIndex = 16;
            this.comboBoxRutaA.SelectedIndexChanged += new System.EventHandler(this.comboBoxRutaA_SelectedIndexChanged);
            // 
            // labelRutas
            // 
            this.labelRutas.AutoSize = true;
            this.labelRutas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRutas.Location = new System.Drawing.Point(10, 6);
            this.labelRutas.Name = "labelRutas";
            this.labelRutas.Size = new System.Drawing.Size(65, 22);
            this.labelRutas.TabIndex = 15;
            this.labelRutas.Text = "Ruta A:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 42);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(946, 713);
            this.crystalReportViewer1.TabIndex = 14;
            // 
            // comboBoxRutaB
            // 
            this.comboBoxRutaB.FormattingEnabled = true;
            this.comboBoxRutaB.Location = new System.Drawing.Point(310, 10);
            this.comboBoxRutaB.Name = "comboBoxRutaB";
            this.comboBoxRutaB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRutaB.TabIndex = 18;
            this.comboBoxRutaB.SelectedIndexChanged += new System.EventHandler(this.comboBoxRutaB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ruta B:";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(450, 5);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(116, 28);
            this.buttonConsultar.TabIndex = 19;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // frmRutasReplicadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 761);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.comboBoxRutaB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRutaA);
            this.Controls.Add(this.labelRutas);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmRutasReplicadas";
            this.Text = "frmRutasReplicadas";
            this.Load += new System.EventHandler(this.frmRutasReplicadas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRutaA;
        private System.Windows.Forms.Label labelRutas;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBoxRutaB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConsultar;
    }
}