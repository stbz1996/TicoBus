using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moduloCompañia
{
    public class DatosConexion
    {
        //datos para la conexion
        String serv;
        String user;
        String password;
        String database;

        MySqlConnectionStringBuilder stringConexion = new MySqlConnectionStringBuilder();

        public DatosConexion()
        {
            
                serv = "localhost";
                user = "escritorio";
                password = "12345";
                database = "ticobus";
               
                stringConexion.Server = "localhost";
                stringConexion.UserID = user;
                stringConexion.Password = password;
                stringConexion.Database = database;
            

        }
        public DatosConexion(string usuario, string pass)
        {
            serv = "localhost";
            user = usuario;
            password = pass;
            database = "ticobus";

            stringConexion.Server = serv;
            stringConexion.UserID = user;
            stringConexion.Password = password;
            stringConexion.Database = database;
        }

        public string getStringConexion()
        {
            return stringConexion.ToString();
        }
        public string getUsuario()
        {
            return user;
        }
    }
    
}
