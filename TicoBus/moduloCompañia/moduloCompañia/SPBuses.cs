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

    class SPBuses
    {
        MySqlConnection conexion;


        MySqlCommand comando;

        public SPBuses(Conexion c)
        {
            conexion = c.getMySqlConnection();
        }

        public void modificarBus(int placa, String modelo, int capacidad, int estado)
       {
           conexion.Open();
           comando = new MySqlCommand("modificarBus", conexion);
           comando.CommandType = CommandType.StoredProcedure;
           comando.Parameters.Add("placaBus", MySqlDbType.Int32).Value = placa;
           comando.Parameters.Add("modeloBus", MySqlDbType.VarChar).Value = modelo;
           comando.Parameters.Add("capacidadBus", MySqlDbType.Int32).Value = capacidad;
           comando.Parameters.Add("estadoBus", MySqlDbType.Int32).Value = estado;

           comando.ExecuteNonQuery();
           conexion.Close();

       }
        public Autobus consultarBus(int placa)
        {
            conexion.Open();
            comando = new MySqlCommand("consultarBus", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("placaBus", MySqlDbType.Int32).Value = placa;

            MySqlParameter modelo = new MySqlParameter("modeloBus", MySqlDbType.VarChar);
            modelo.Direction = ParameterDirection.Output;
            comando.Parameters.Add(modelo);
            comando.Parameters["modeloBus"].Direction = ParameterDirection.Output;

            MySqlParameter capacidad = new MySqlParameter("capacidadBus", MySqlDbType.Int32);
            capacidad.Direction = ParameterDirection.Output;
            comando.Parameters.Add(capacidad);
            comando.Parameters["capacidadBus"].Direction = ParameterDirection.Output;

            MySqlParameter estado = new MySqlParameter("estadoBus", MySqlDbType.Int32);
            estado.Direction = ParameterDirection.Output;
            comando.Parameters.Add(estado);
            comando.Parameters["estadoBus"].Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            conexion.Close();

            return new Autobus(placa, comando.Parameters["modeloBus"].Value.ToString(), Convert.ToInt32(comando.Parameters["capacidadBus"].Value.ToString()), Int32.Parse(comando.Parameters["estadoBus"].Value.ToString()));
        }

        //crea un nuevo autobus en la BD, devuelve un string si se ejecuta correctamente o si ya se encuentra la placa
        public String crearAutobus(String SP, int placa, String modelo, int capacidad, long cedula)
        {
            conexion.Open();
            comando = new MySqlCommand(SP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("numPlaca", MySqlDbType.Int32).Value = placa;
            comando.Parameters.Add("nombreModelo", MySqlDbType.VarChar).Value = modelo;
            comando.Parameters.Add("cantCapacidad", MySqlDbType.Int32).Value = capacidad;
            comando.Parameters.Add("pCedulaJuridica", MySqlDbType.Int64).Value = cedula;
            String mensaje = validarSPEmpresa(comando, conexion, SP);
            return mensaje;


        }
        public String agregarAutobusAEmpresa(long cedulaJ, int placa)
        {
            conexion.Open();
            comando = new MySqlCommand("agregarAutobusAEmpresa", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("cedJuridica", MySqlDbType.Int64).Value = cedulaJ;
            comando.Parameters.Add("numPlaca", MySqlDbType.Int32).Value = placa;

            return validarSPEmpresa(comando, conexion, "agregarAutobusAEmpresa");


        }
        public String validarSPEmpresa(MySqlCommand comand, MySqlConnection conection, String storeProcedure)
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
                if (storeProcedure.Equals("crearEmpresa"))

                    mensaje = "La cedula juridica ya se encuentra registrada";

                if (storeProcedure.Equals("crearAutobus"))
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
