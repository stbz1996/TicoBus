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
    public partial class CrearEmpresa : Form
    {
        Controlador control;
        Conexion c = new Conexion(new DatosConexion());
        public CrearEmpresa()
        {
            control = new Controlador(c);
            InitializeComponent();
            
        }

        private void txtCedulaJuridica_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarEmpresa_Click(object sender, EventArgs e)
        {
            

            long cedula = Convert.ToInt64(txtCedulaJuridica.Text);
            String nombre = txtNombreEmpresa.Text;
            long numCuenta = Convert.ToInt64(txtCuenta.Text);
            String clave = txtPassword.Text;
            bool validar = control.crearEmpresa(nombre, cedula, numCuenta, clave);
            

            if (validar)
            {
                    
                    this.Hide();
                    agregarRutasyBuses RutasBuses = new agregarRutasyBuses(control);
                    RutasBuses.Show();
                }
            }
            
                
            

        }
    }

