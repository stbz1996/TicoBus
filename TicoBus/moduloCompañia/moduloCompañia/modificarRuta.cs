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
    public partial class modificarRuta : Form
    {
        Controlador control;
        int indiceRuta;
        int idRuta;
        public modificarRuta(Controlador manager, int indice)
        {
            control = manager;
            indiceRuta = indice;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaParadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modificarRuta_Load(object sender, EventArgs e)
        {

            Ruta ruta = control.consultarRuta(indiceRuta);
            labelNombre.Text = ruta.getNombre();   
            txtTarifa.Text = ruta.getTarifa().ToString();
            if (ruta.getEstado() == 1)
                boxEstado.SelectedText = boxEstado.Items[0].ToString();
            else
                boxEstado.SelectedText = boxEstado.Items[1].ToString();
            listaParadas = control.mostrarParadasDeRuta(listaParadas, ruta.getId());
            idRuta = ruta.getId();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            control.modificarRuta(idRuta, int.Parse(txtTarifa.Text), boxEstado.Text, listaParadas);
            this.Hide();
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();
        }

        private void modificarRuta_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatosEmpresa empresa = new DatosEmpresa(control);
            empresa.Show();
        }

        private void boxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
