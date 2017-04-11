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
    public partial class frmRutasReplicadas : Form
    {
        Controlador control;
        public frmRutasReplicadas(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void frmRutasReplicadas_Load(object sender, EventArgs e)
        {
            comboBoxRutaA = control.obtenerRutas(comboBoxRutaA);
            comboBoxRutaB = control.obtenerRutas(comboBoxRutaB);
        }

        private void comboBoxRutaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRutaB.Items.RemoveAt(comboBoxRutaA.SelectedIndex);

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            
            reporteRutasReplicadas nuevoReporte = new reporteRutasReplicadas();
            nuevoReporte.SetDataSource(control.ObtenerReporteRutasReplicadas(comboBoxRutaA.Text, comboBoxRutaB.Text)); 

            crystalReportViewer1.ReportSource = nuevoReporte;


        }

        private void comboBoxRutaB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
