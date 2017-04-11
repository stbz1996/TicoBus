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
    public partial class frmRutasFrecuentes : Form
    {
        Controlador control;
        DataTable rutasFrecuentes;
        public frmRutasFrecuentes(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        

        private void buttonFiltrarFecha_Click(object sender, EventArgs e)
        {

            DataView copia = new DataView(rutasFrecuentes);

            copia.RowFilter = " (FechaInicio >= #" +
            Convert.ToDateTime(dateTimeDesde.Text).ToString("MM/dd/yyyy") +
         "# And FechaInicio <= #" +
        Convert.ToDateTime(dateTimeHasta.Text).ToString("MM/dd/yyyy") +
         "# ) ";

            reporteRutasFrecuentes nuevoReporte = new reporteRutasFrecuentes();
            nuevoReporte.SetDataSource(copia.ToTable());
            rutasFrecuentes = copia.ToTable();
            crystalReportViewer1.ReportSource = nuevoReporte;

        }

        private void frmRutasFrecuentes_Load(object sender, EventArgs e)
        {
            comboBoxEmpresas = control.consultarEmpresas(comboBoxEmpresas);
            reporteRutasFrecuentes nuevoReporte = new reporteRutasFrecuentes();
            nuevoReporte.SetDataSource(control.ObtenerReporteRutasFrecuentes());
            rutasFrecuentes = control.ObtenerReporteRutasFrecuentes();

            crystalReportViewer1.ReportSource = nuevoReporte;
        }

        private void labelRutas_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView copia = new DataView(control.ObtenerReporteRutasFrecuentes());
            copia.RowFilter = "nombreEmpresa like '%" + comboBoxEmpresas.Text + "%'";
            reporteRutasFrecuentes nuevoReporte = new reporteRutasFrecuentes();
            nuevoReporte.SetDataSource(copia.ToTable());
            rutasFrecuentes = copia.ToTable();
            crystalReportViewer1.ReportSource = nuevoReporte;
        }
    }
}
