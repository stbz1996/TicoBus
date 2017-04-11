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
    public partial class agregarRuta : Form
    {
        Controlador control;
        agregarRutasyBuses Padre;
        DatosEmpresa ventana;
        int opcionVentana;
 
        public agregarRuta(agregarRutasyBuses ventana, Controlador c)
        {
            control = c;
            Padre = ventana;
            InitializeComponent();
            opcionVentana = 1;
        }
        public agregarRuta(DatosEmpresa ventanaPadre, Controlador c)
        {
            control = c;
            ventana = ventanaPadre;
            InitializeComponent();
            opcionVentana = 2;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarAutobus_Click(object sender, EventArgs e)
        {

            String nombre = txtNombre.Text;
            int tarifa = Convert.ToInt32(txtTarifa.Text);
            bool validar = control.crearRuta(nombre, tarifa, listaParadas);

            if (validar)
            {
               
                if (opcionVentana == 1)
                    Padre.agregarItemRuta(txtNombre.Text);
                else
                    ventana.agregarItemRuta(txtNombre.Text);
             
                this.Hide();

            }

        }

        private void agregarRuta_Load(object sender, EventArgs e)
        {
             control.mostrarParadas(listaParadas);
        }

        private void listaParadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
