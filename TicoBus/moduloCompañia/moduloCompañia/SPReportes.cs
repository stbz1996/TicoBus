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
    class SPReportes
    {
        MySqlConnection conexion;

        MySqlCommand comando;

        public SPReportes(Conexion c)
        {
            conexion = c.getMySqlConnection();
        }

        public DataSetReportes reporteRutasReplicadas(int idRutaA, int idRutaB)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("reporteRutasReplicadas", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("idRutaA", MySqlDbType.Int32).Value = idRutaA;
            comando.Parameters.Add("idRutaB", MySqlDbType.Int32).Value = idRutaB;

            MySqlParameter cantidad = new MySqlParameter("CantidadParadasReplicadas", MySqlDbType.Int64);
            cantidad.Direction = ParameterDirection.Output;
            comando.Parameters.Add(cantidad);

            comando.Parameters["CantidadParadasReplicadas"].Direction = ParameterDirection.Output;


            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataSetReportes datos = new DataSetReportes();
            DataTable dt = new DataTable("rutasReplicadas");
            DataTable tablaCantidad = new DataTable("CantidadParadas");
            adaptador.Fill(dt);

            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "CantidadParadasReplicadas";
            tablaCantidad.Columns.Add(column);



            DataRow row = tablaCantidad.NewRow();
            row["CantidadParadasReplicadas"] = Int64.Parse(comando.Parameters["CantidadParadasReplicadas"].Value.ToString());
           
            tablaCantidad.Rows.Add(row);
            datos.Tables["rutasReplicadas"].Merge(dt);
            datos.Tables["CantidadParadas"].Merge(tablaCantidad);
            comando.ExecuteNonQuery();
            conexion.Close();
            return datos;
        }
        public DataSetReportes reportes(String sp)
        {
            string nombreTabla = "";
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(sp, conexion);
            comando.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataSetReportes datos = new DataSetReportes();
            if (sp.Equals("reporteHistorialTarifas"))
            {
                nombreTabla = "informeTarifa";
            }
            if (sp.Equals("reporteCantidadPasajeros"))
            {
                nombreTabla = "cantidadUsuarios";
            }
            if (sp.Equals("rutasFrecuentes"))
            {
                nombreTabla = "rutasFrecuentes";
            }

            DataTable dt = new DataTable(nombreTabla);
            adaptador.Fill(dt);
            datos.Tables[nombreTabla].Merge(dt);
            conexion.Close();
            return datos;
        }
        public DataTable obtenerRutasOParadasOEmpresas(string sp)
        {
            conexion.Open();
            comando = new MySqlCommand(sp, conexion);
            comando.CommandType = CommandType.StoredProcedure;

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
