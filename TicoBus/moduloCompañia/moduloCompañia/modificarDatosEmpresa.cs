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
    public partial class modificarDatosEmpresa : Form
    {
        Controlador control;
        public modificarDatosEmpresa( Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void modificarDatosEmpresa_Load(object sender, EventArgs e)
        {
            txtCuenta.Text = control.getCuenta().ToString();
            txtNombreEmpresa.Text = control.getNombreEmpresa();
        }

        private void modificarDatos_Click(object sender, EventArgs e)
        {
            control.modificarDatosEmpresa(txtNombreEmpresa.Text, Int64.Parse(txtCuenta.Text));
            this.Hide();
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();

        }

        private void modificarDatosEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();
        }
    }
}
