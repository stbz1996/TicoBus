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
    public partial class agregarBus : Form
    {
        Controlador control;
        agregarRutasyBuses Padre;
        DatosEmpresa ventana;
        int opcionVentana;
        

        public agregarBus(agregarRutasyBuses ventana, Controlador c)
        {
            control = c;
            Padre = ventana;
            opcionVentana = 1;
            InitializeComponent();
        }
        public agregarBus(DatosEmpresa ventanaPadre, Controlador c)
        {
            control = c;
            ventana = ventanaPadre;
            opcionVentana = 2;
            InitializeComponent();
        }

        private void agregarAutobus_Click(object sender, EventArgs e)
        {
            int placa = Convert.ToInt32(txtPlaca.Text);
            String modelo = txtModelo.Text;
            int capacidad = Convert.ToInt32(txtCapacidad.Text);

            bool validar = control.crearAutobus(placa, modelo, capacidad);


            if (validar)
            {
                
                if(opcionVentana ==1)
                    Padre.agregarItem(txtPlaca.Text);
                else
                    ventana.agregarItemBus(txtPlaca.Text);
                this.Hide();
                
            }
          

        }

        private void agregarBus_Load(object sender, EventArgs e)
        {

        }
    }
}
