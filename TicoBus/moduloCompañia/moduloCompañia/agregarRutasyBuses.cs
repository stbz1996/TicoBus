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
    public partial class agregarRutasyBuses : Form
    {
        Controlador control;
        public agregarRutasyBuses(Controlador c)
        {
            control = c;
            InitializeComponent();
        }

        private void agregarRutasyBuses_Load(object sender, EventArgs e)
        {

        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            CrBus programa = new CrBus();
            programa.Show();
        }

        private void agregarAutobus_Click(object sender, EventArgs e)
        {
            agregarBus bus = new agregarBus(this, control);
            bus.Show();

        }
        public void agregarItem(String placa)
        {
            listaBuses.Items.Add(placa);
        }
        public void agregarItemRuta(String ruta)
        {
            listaRutas.Items.Add(ruta);
        }

        private void agregarRuta_Click(object sender, EventArgs e)
        {
            agregarRuta ruta = new agregarRuta(this, control);
            ruta.Show();
        }

        private void agregarRuta_Click_1(object sender, EventArgs e)
        {
            agregarRuta ruta = new agregarRuta(this, control);
            ruta.Show();
        }
    }
}
