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
    public partial class frmCantidadUsuarios : Form
    {
        Controlador control;
        DataTable cantidadUsuarios;
        public frmCantidadUsuarios(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void frmCantidadUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxEmpresas = control.consultarEmpresas(comboBoxEmpresas);
            reporteCantidadUsuarios nuevoReporte = new reporteCantidadUsuarios();
            nuevoReporte.SetDataSource(control.ObtenerReporteCantidadUsuarios());
            cantidadUsuarios = control.ObtenerReporteCantidadUsuarios();


            crystalReportViewer1.ReportSource = nuevoReporte;

        }

        private void comboBoxEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView copia = new DataView(control.ObtenerReporteCantidadUsuarios());
            copia.RowFilter = "nombreEmpresa like '%" + comboBoxEmpresas.Text + "%'";
            reporteCantidadUsuarios nuevoReporte = new reporteCantidadUsuarios();
            nuevoReporte.SetDataSource(copia.ToTable());
            cantidadUsuarios = copia.ToTable();
            crystalReportViewer1.ReportSource = nuevoReporte;
        }

        private void buttonFiltrarFecha_Click(object sender, EventArgs e)
        {
            DataView copia = new DataView(cantidadUsuarios);

            copia.RowFilter = " (fecha >= #" +
            Convert.ToDateTime(dateTimeDesde.Text).ToString("MM/dd/yyyy") +
         "# And fecha <= #" +
        Convert.ToDateTime(dateTimeHasta.Text).ToString("MM/dd/yyyy") +
         "# ) ";

            reporteCantidadUsuarios nuevoReporte = new reporteCantidadUsuarios();
            nuevoReporte.SetDataSource(copia.ToTable());
            crystalReportViewer1.ReportSource = nuevoReporte;
        }
    }
}
