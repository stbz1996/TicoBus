using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace moduloCompañia
{
    public class Conexion
    {
        DatosConexion stringConexion;
        bool datosValidos = true;

     
        MySqlConnection conn;
       public  Conexion(DatosConexion datosConexion)
        {
            try
            {
                stringConexion = datosConexion;
                conn = new MySqlConnection(stringConexion.getStringConexion());
                conn.Open();
                conn.Close();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto, datos no validos" );
                datosValidos = false;
            }
        }
        public MySqlConnection getMySqlConnection()
        {
            return conn;
        }
        public String getUsuario()
        {
            return stringConexion.getUsuario();
        }
        public bool getDatosValidos()
        {
            return datosValidos;
        }

        
    }
}
