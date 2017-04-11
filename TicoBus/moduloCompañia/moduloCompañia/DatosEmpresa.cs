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
    public partial class DatosEmpresa : Form

    {
        Controlador control;
        public DatosEmpresa(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void DatosEmpresa_Load(object sender, EventArgs e)
        {
            txtCedulaJuridica.Text = control.getUsuario();
            control.datosEmpresa(control.getUsuario());
            txtCuenta.Text = control.getCuenta().ToString();
            labelNombre.Text = control.getNombreEmpresa();
            listaBuses = control.mostarBuses(listaBuses);
            listaRutas = control.mostarRutas(listaRutas);
        }
        public void agregarItemBus(String placa)
        {
            listaBuses.Items.Add(placa);
        }
        public void agregarItemRuta(String ruta)
        {
            listaRutas.Items.Add(ruta);
        }

        private void agregarAutobus_Click(object sender, EventArgs e)
        {
           
            agregarBus bus = new agregarBus(this, control);
            bus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            modificarDatosEmpresa modificar = new modificarDatosEmpresa(control);
            modificar.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listaBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            modificarBus modificarBus = new modificarBus(control,Convert.ToInt32(listaBuses.SelectedItem.ToString()));
            modificarBus.Show();
           
        }

        private void agregarRuta_Click(object sender, EventArgs e)
        {
            
            agregarRuta ruta = new agregarRuta(this, control);
            ruta.Show();
        }

        private void listaRutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            modificarRuta modificarRuta = new modificarRuta(control, listaRutas.SelectedIndex);
            modificarRuta.Show();
        }

        private void DatosEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            CrBus inicio = new CrBus();
            inicio.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportes ventanaReportes = new reportes(control);
            ventanaReportes.Show();
        }
    }
}
