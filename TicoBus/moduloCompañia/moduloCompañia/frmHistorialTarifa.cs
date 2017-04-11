using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moduloCompañia
{
    public partial class frmHistorialTarifa : Form
    {
        Controlador control;
        public frmHistorialTarifa(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void frmHistorialTarifa_Load(object sender, EventArgs e)
        {
            comboBoxRutaA = control.obtenerRutas(comboBoxRutaA);
            reporteHistoricoTarifas nuevoReporte = new reporteHistoricoTarifas();
            nuevoReporte.SetDataSource(control.ObtenerReporteTarifas());
            


            crystalReportViewer1.ReportSource = nuevoReporte;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

       

        

        private void comboBoxRutaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView copia = new DataView(control.ObtenerReporteTarifas());
            copia.RowFilter = "nombreRuta like '%" + comboBoxRutaA.Text + "%'";
            reporteHistoricoTarifas nuevoReporte = new reporteHistoricoTarifas();
            nuevoReporte.SetDataSource(copia.ToTable());
            crystalReportViewer1.ReportSource = nuevoReporte;

        }
    }
}
