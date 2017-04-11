using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace moduloCompañia
{

    class SPEmpresa
    {
        MySqlConnection conexion;

      
        MySqlCommand comando;

        public SPEmpresa(Conexion c)
        {
            conexion = c.getMySqlConnection();
        }
        
        public Empresa modificarDatosEmpresa(long cedJur, String nombre, long cuenta)
        {
            conexion.Open();
            comando = new MySqlCommand("modificarDatosEmpresa", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedJuridica", MySqlDbType.Int64).Value = cedJur;
            comando.Parameters.Add("nombreEmpresa", MySqlDbType.String).Value = nombre;
            comando.Parameters.Add("numCuenta", MySqlDbType.Int64).Value = cuenta;

            comando.ExecuteNonQuery();
            conexion.Close();

            Empresa emp = new Empresa(nombre, cedJur, cuenta, "");

            return emp;

        }

        //consultarBuses de una empresa
        public DataTable consultarBusesORutaPorEmpresa( long cedulaJuridica, string sp)
        {
            conexion.Open();
            comando = new MySqlCommand(sp, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedula", MySqlDbType.Int64).Value = cedulaJuridica;


            DataSet datos = new DataSet();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(datos);
            DataTable tabla = datos.Tables[0];
            conexion.Close();
            return tabla;
        }
       
        
        //datos empresa
        public Empresa datosEmpresa( long cedJur)
        {
            conexion.Open();
            comando = new MySqlCommand("datosEmpresa", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedJuridica", MySqlDbType.Int64).Value = cedJur;

            MySqlParameter nombreEmpresa = new MySqlParameter("nombreEmpresa", MySqlDbType.String);
            nombreEmpresa.Direction = ParameterDirection.Output;
            comando.Parameters.Add(nombreEmpresa);
            comando.Parameters["nombreEmpresa"].Direction = ParameterDirection.Output;

            MySqlParameter numeroCuenta = new MySqlParameter("numCuenta", MySqlDbType.Int64);
            numeroCuenta.Direction = ParameterDirection.Output;
            comando.Parameters.Add(numeroCuenta);
            comando.Parameters["numCuenta"].Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            conexion.Close();
            
            return new Empresa(comando.Parameters["nombreEmpresa"].Value.ToString(), cedJur, Int64.Parse(comando.Parameters["numCuenta"].Value.ToString()),"");

        }
        //Funcion que se encarga de abrir una conexion a la base, crea una empresa 
        //cierra la conexion una vez que accedio al SP.
        public String crerEmpresa( String SP, long cedJur, String nombre, long numCuenta)
        {
            conexion.Open();
            comando = new MySqlCommand(SP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedJuridica", MySqlDbType.Int64).Value = cedJur;
            comando.Parameters.Add("nombreEmpresa", MySqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("numCuenta", MySqlDbType.Int64).Value = numCuenta;

           return validarSPEmpresa(comando, conexion, SP);
        }
        
        //crea un usuario a la base de datos con la cedula y contraseña
        public void crearUsuarioBD(long cedJur, String pass)
        {
            String cedula = cedJur.ToString();
            conexion.Open();
            comando = new MySqlCommand("crearUsuarioBD", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedJuridica", MySqlDbType.VarChar).Value = cedula;
            comando.Parameters.Add("varPassword", MySqlDbType.VarChar).Value = pass;

            comando.ExecuteNonQuery();
            conexion.Close();
        }
        

        public String validarSPEmpresa( MySqlCommand comand, MySqlConnection conection, String storeProcedure)
        {
            String mensaje = "Se ha registrado correctamente"; 
            MySqlParameter validar = new MySqlParameter("validacion", MySqlDbType.Int64);
            validar.Direction = ParameterDirection.Output;
            comand.Parameters.Add(validar);

            comand.Parameters["validacion"].Direction = ParameterDirection.Output;

            comand.ExecuteNonQuery();
            conexion.Close();
            long val = Int64.Parse(comand.Parameters["validacion"].Value.ToString());
            if (val == 0)
            {
                if(storeProcedure.Equals("crearEmpresa"))

                    mensaje = "La cedula juridica ya se encuentra registrada";

                if(storeProcedure.Equals("crearAutobus"))
                    mensaje = "El autobus ya se encuentra registrado";
                else
                {
                    mensaje = "Error al registradarse";
                }
            }
            
            return mensaje;
        }

    }
}
