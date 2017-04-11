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
    public partial class reportes : Form
    {
        Controlador control;
        public reportes(Controlador c )
        {
            control = c;
            InitializeComponent();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            frmRutasFrecuentes ventana = new frmRutasFrecuentes(control);
            ventana.Show();

        }

        private void reportes_Load(object sender, EventArgs e)
        {

        }

        private void reportes_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosEmpresa ventana = new DatosEmpresa(control);
            ventana.Show();
        }

        private void historicoTarifas_Click(object sender, EventArgs e)
        {
            
            frmHistorialTarifa ventana = new frmHistorialTarifa(control);
            ventana.Show();

        }

        private void cantidadUsuario_Click(object sender, EventArgs e)
        {
            frmCantidadUsuarios ventana = new frmCantidadUsuarios(control);
            ventana.Show();
        }

        private void rutasReplicadas_Click(object sender, EventArgs e)
        {
            frmRutasReplicadas ventana = new frmRutasReplicadas(control);
            ventana.Show();

        }
    }
}
