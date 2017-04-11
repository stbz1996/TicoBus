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
    class SPRuta
    {
        MySqlConnection conexion;

        MySqlCommand comando;

        public SPRuta(Conexion c)
        {
            conexion = c.getMySqlConnection();
        }
        public void modificarRuta(int id, int tarifa, int estado)
        {
            conexion.Open();
            comando = new MySqlCommand("modificarRuta", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ruta", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("tarifaRuta", MySqlDbType.VarChar).Value = tarifa;
            comando.Parameters.Add("estadoRuta", MySqlDbType.Int32).Value = estado;

            comando.ExecuteNonQuery();
            conexion.Close();
        }
        //elimina o inserta una fila a la tabla paradaporruta
        public void modificarParadaPorRuta(int idRuta, int idParada, string sp)
        {
            conexion.Open();
            comando = new MySqlCommand(sp, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ruta", MySqlDbType.Int32).Value = idRuta;
            comando.Parameters.Add("parada", MySqlDbType.Int32).Value = idParada;

            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public int insertarRuta(String SP, String nombre, int tarifa, long cedulaJuridica)
        {
            conexion.Open();
            comando = new MySqlCommand(SP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("pNombre", MySqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("pTarifa", MySqlDbType.Int32).Value = tarifa;
            comando.Parameters.Add("pCedulaJuridica", MySqlDbType.Int64).Value = cedulaJuridica;
            MySqlParameter id = new MySqlParameter("pIdRuta", MySqlDbType.Int32);
            id.Direction = ParameterDirection.Output;
            comando.Parameters.Add(id);

            comando.Parameters["pIdRuta"].Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            conexion.Close();
            return Int32.Parse(comando.Parameters["pIdRuta"].Value.ToString());

        }
        public Ruta consultarRuta(int id)
        {
            conexion.Open();
            comando = new MySqlCommand("consultarRuta", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("id", MySqlDbType.Int32).Value = id;


            MySqlParameter nombre = new MySqlParameter("nombreRuta", MySqlDbType.VarChar);
            nombre.Direction = ParameterDirection.Output;
            comando.Parameters.Add(nombre);
            comando.Parameters["nombreRuta"].Direction = ParameterDirection.Output;

            MySqlParameter tarifa = new MySqlParameter("tarifaRuta", MySqlDbType.Int32);
            tarifa.Direction = ParameterDirection.Output;
            comando.Parameters.Add(tarifa);
            comando.Parameters["tarifaRuta"].Direction = ParameterDirection.Output;

            MySqlParameter estado = new MySqlParameter("estadoRuta", MySqlDbType.Int32);
            estado.Direction = ParameterDirection.Output;
            comando.Parameters.Add(estado);
            comando.Parameters["estadoRuta"].Direction = ParameterDirection.Output;

            comando.ExecuteNonQuery();
            conexion.Close();


            return new Ruta(id, comando.Parameters["nombreRuta"].Value.ToString(), Convert.ToInt32(comando.Parameters["tarifaRuta"].Value.ToString()), Int32.Parse(comando.Parameters["estadoRuta"].Value.ToString()));
        }
        //consultar paradas de una ruta
        public DataTable consultarParadasPorRuta(int idRuta)
        {
            conexion.Open();
            comando = new MySqlCommand("consultaParadasRuta", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("pRuta", MySqlDbType.Int32).Value = idRuta;

            DataSet datos = new DataSet();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            adaptador.Fill(datos);
            DataTable tabla = datos.Tables[0];

            conexion.Close();
            return tabla;
        }

    }
}
