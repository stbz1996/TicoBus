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
    public partial class modificarBus : Form
    {
        Controlador control;
        int placa;
        public modificarBus(Controlador c, int placaBus)
        {
            placa = placaBus;
            control = c;
            InitializeComponent();
        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelPlaca_Click(object sender, EventArgs e)
        {

        }

        private void modificarBus_Load(object sender, EventArgs e)
        {
            labelPlaca.Text = placa.ToString();
            Autobus bus = control.consultarBus(placa);
            txtCapacidad.Text = bus.getCapacidad().ToString();
            txtModelo.Text = bus.getModelo().ToString();
            if (bus.getEstado() == 1)
                boxEstado.SelectedText = boxEstado.Items[0].ToString();
            else
                boxEstado.SelectedText = boxEstado.Items[1].ToString();
        }

        private void modificarAutobus_Click(object sender, EventArgs e)
        {
            
            control.modificarBus(placa, txtModelo.Text, Int32.Parse(txtCapacidad.Text), boxEstado.Text);
            MessageBox.Show("Se modifico correctamente");
            this.Hide();
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();
        }

        private void modificarBus_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();
        }
    }
}
