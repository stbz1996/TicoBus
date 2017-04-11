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
    public partial class CrBus : Form
    {
        Controlador control;
        public CrBus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCedulaJuridica_Click(object sender, EventArgs e)
        {
            txtCedulaJuridica.Text = "";
           
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void crearEmpresa_Click(object sender, EventArgs e)
        {
            CrearEmpresa crear = new CrearEmpresa();
            this.Visible = false;
            crear.Show();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            control = new Controlador(txtCedulaJuridica.Text, txtPassword.Text);
            if(control.validarConexion())
            {
                DatosEmpresa datosEmpresa = new DatosEmpresa(control);
                datosEmpresa.Show();
                this.Hide();
            }
            
        }
    }
}
