using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace moduloCompañia
{
    public class Controlador
    {
        Empresa empresa = new Empresa();
        SPEmpresa proceduresEmpresa;
        SPBuses proceduresBuses ;
        SPReportes proceduresReportes;
        SPRuta proceduresRutas;
        Conexion conexion;
        DataTable paradas;
        DataTable rutas;
        public Controlador(Conexion c)
        {
            conexion = c;
            proceduresEmpresa = new SPEmpresa(conexion);
            proceduresBuses = new SPBuses(conexion);
            proceduresReportes = new SPReportes(conexion);
            proceduresRutas = new SPRuta(conexion);
        }

        public Controlador ( string cedulaJuridica, string password)
        {
            DatosConexion datos = new DatosConexion(cedulaJuridica, password);
            conexion = new Conexion(datos);
            proceduresEmpresa = new SPEmpresa(conexion);
            proceduresBuses = new SPBuses(conexion);
            proceduresReportes = new SPReportes(conexion);
            proceduresRutas = new SPRuta(conexion);

        }
        public bool validarConexion()
        {
            return conexion.getDatosValidos();
        }

        public long getCedulaEmpresa()
        {
            return empresa.getCedula();
        }

      
        public void datosEmpresa( string cedulaJuridica)
        {
            long cedula = Int64.Parse(cedulaJuridica.ToString());
            empresa= proceduresEmpresa.datosEmpresa(cedula);
            

        }
        public DataTable ObtenerReporteTarifas()
        {
            String storeProcedure = "reporteHistorialTarifas";
            DataSetReportes datos = proceduresReportes.reportes(storeProcedure);

            return datos.Tables["informeTarifa"];

        }
        public DataTable ObtenerReporteRutasFrecuentes()
        {
            String storeProcedure = "rutasFrecuentes";
            DataSetReportes datos = proceduresReportes.reportes(storeProcedure);


            return datos.Tables["rutasFrecuentes"];

        }
        public DataTable ObtenerReporteCantidadUsuarios()
        {
            String sp = "reporteCantidadPasajeros";
            DataSetReportes datos = proceduresReportes.reportes(sp);


            return datos.Tables["cantidadUsuarios"];

        }
        public DataSetReportes ObtenerReporteRutasReplicadas(string rutaA, string rutaB)
        {
            int idrutaA = 0, idrutaB = 0;
            foreach(DataRow fila in rutas.Rows)
            {
                if (fila.ItemArray[1].ToString().Equals(rutaA))
                    idrutaA = Int32.Parse(fila.ItemArray[0].ToString());
                if (fila.ItemArray[1].ToString().Equals(rutaB))
                    idrutaB = Int32.Parse(fila.ItemArray[0].ToString());

            }
            DataSetReportes datos = proceduresReportes.reporteRutasReplicadas(idrutaA, idrutaB);

            return datos;

        }
        public void modificarDatosEmpresa(String nuevoNombre, long nuevaCuenta)
        {
            
            long cedula = Int64.Parse(getUsuario());
            String validar = validarDatosEmpresa(nuevoNombre, cedula, nuevaCuenta,"password");
            if (validar.Equals("Datos correctos"))
            {
                empresa = proceduresEmpresa.modificarDatosEmpresa(cedula, nuevoNombre, nuevaCuenta);
            }
          
        }
        public void modificarBus(int placa, String modelo, int capacidad, string estado)
        {
            int estadoBus = 0;
            if (estado.Equals("Activado"))
                estadoBus = 1;
            proceduresBuses.modificarBus(placa, modelo, capacidad, estadoBus);    

        }

        public Autobus consultarBus(int placa)
        {
            return proceduresBuses.consultarBus(placa);

        }

        public CheckedListBox mostrarParadas(CheckedListBox listaParadas)
        {
            string storeProcedure = "consultarParadas";
            DataTable tabla = proceduresReportes.obtenerRutasOParadasOEmpresas(storeProcedure);
            paradas = tabla;
            
            foreach (DataRow fila in tabla.Rows)
            {
                listaParadas.Items.Add(fila.ItemArray[0].ToString());
             }
           

            return listaParadas;
        }
        public void modificarRuta(int idRuta, int tarifa, string activado, CheckedListBox listaParadas)
        {
            string storeP = "consultarParadas";
            int estado = 0;
           if (activado.Equals("Activado"))
            {
                estado = 1;
            }

            DataTable paradasRutaSinModificar = proceduresRutas.consultarParadasPorRuta(idRuta);
            proceduresRutas.modificarRuta(idRuta, tarifa, estado);

            paradas = proceduresReportes.obtenerRutasOParadasOEmpresas(storeP);
            for(int i = 0; i < listaParadas.Items.Count; i++)
            {
                DataRow l = paradas.Rows[i];
                int idParada = Convert.ToInt32(l.ItemArray[1].ToString());
                string sp = "";

                if (listaParadas.GetItemChecked(i))
                {
                    bool esta = inParadasSinModificar(idParada, paradasRutaSinModificar);
                    if( !esta)
                    {
                        sp = "insertarParadaPorRuta";
                        proceduresRutas.modificarParadaPorRuta(idRuta, idParada, sp);
                    }
                }
                if (!listaParadas.GetItemChecked(i))
                {
                    bool esta = inParadasSinModificar(idParada, paradasRutaSinModificar);
                    if (esta)
                    {
                        sp = "eliminarParadaPorRuta";
                        proceduresRutas.modificarParadaPorRuta(idRuta, idParada, sp);
                    }

                }

            }

        }
        public bool inParadasSinModificar(int idParada, DataTable paradasRutaSinModificar)
        {
            int validar = 0;

            foreach(DataRow fila in paradasRutaSinModificar.Rows)
            {
                if (Int32.Parse(fila.ItemArray[0].ToString()) == idParada)
                    validar++;


            }
            if(validar > 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
            

        public CheckedListBox mostrarParadasDeRuta(CheckedListBox listaParadas, int idRuta)
        {
            string storeP = "consultarParadas";
            DataTable paradasBD = proceduresReportes.obtenerRutasOParadasOEmpresas(storeP);
            paradas = paradasBD;
            DataTable paradasRuta = proceduresRutas.consultarParadasPorRuta(idRuta);
            int validar = 0;
            foreach (DataRow fila in paradasBD.Rows)
            {
                bool esta = inParadasSinModificar(Int32.Parse(fila.ItemArray[1].ToString()), paradasRuta);
                if (esta)
                {
                    listaParadas.Items.Add(fila.ItemArray[0].ToString(), true);
                }
                else
                {
                    listaParadas.Items.Add(fila.ItemArray[0].ToString(), false);
                }
   
            }

            return listaParadas;
        }

        public ListBox mostarBuses(ListBox listaBuses)

        {
            string storeProcedure = "consultarBusesPorEmpresa";
            DataTable tablaBuses = proceduresEmpresa.consultarBusesORutaPorEmpresa(Int64.Parse(getUsuario()), storeProcedure);

            foreach (DataRow fila in tablaBuses.Rows)
            {
                listaBuses.Items.Add(fila.ItemArray[0].ToString());
            }


            return listaBuses;
        }
        public Ruta consultarRuta(int indice)
        {
            string storeProcedure = "consultarRutaPorEmpresa";
            DataTable rutas = proceduresEmpresa.consultarBusesORutaPorEmpresa(empresa.getCedula(), storeProcedure);
            DataRow rutaBuscada = rutas.Rows[indice];
            Console.WriteLine(rutaBuscada.ItemArray[0].ToString());
            Ruta r = proceduresRutas.consultarRuta(Int32.Parse(rutaBuscada.ItemArray[0].ToString()));

            return r;

        }
        public ListBox mostarRutas(ListBox listaRutas)
        {
            string storeProcedure = "consultarRutaPorEmpresa";
            empresa.setTablaRutas( proceduresEmpresa.consultarBusesORutaPorEmpresa(Int64.Parse(getUsuario()), storeProcedure));
            DataTable tablaRutas = empresa.getTablaRutas();
            foreach (DataRow fila in tablaRutas.Rows)
            {
                listaRutas.Items.Add(fila.ItemArray[1].ToString());
            }


            return listaRutas;
        }

        
        public bool crearEmpresa(String nombreEmpresa, long cedJuridica, long cuenta, String clave)
        {
            bool validar = false;
            String validarDatos = validarDatosEmpresa( nombreEmpresa,  cedJuridica,  cuenta,  clave);
            if (validarDatos.Equals("Datos correctos"))
            {
                String SP = "crearEmpresa";
                empresa = new Empresa(nombreEmpresa, cedJuridica, cuenta, clave);
                String msj = proceduresEmpresa.crerEmpresa(SP, cedJuridica, nombreEmpresa, cuenta);
                MessageBox.Show(msj);
                if(msj.Equals("Se ha registrado correctamente"))
                {
                    validar = true;
                    proceduresEmpresa.crearUsuarioBD(empresa.getCedula(), empresa.getPassword());
                }

            }
            return validar;
        }

        public bool crearAutobus(int placa, String modelo, int capacidad)
        {
            bool validar = false;
            String validarDatos = validarDatosAutobus(placa, modelo, capacidad);
            if (validarDatos.Equals("Datos correctos"))
            {
                String SP = "crearAutobus";
                empresa.agregarAutobus(placa, modelo, capacidad);
                String msj = proceduresBuses.crearAutobus(SP, placa, modelo, capacidad,empresa.getCedula());
                MessageBox.Show(msj);
                if (msj.Equals("Se ha registrado correctamente"))
                {
                    validar = true;
                 }


            }
            return validar;
        }
        public ComboBox consultarEmpresas(ComboBox empresas)
        {
            String storeProcedure = "consultaEmpresa";
            DataTable tablaEmpresas = proceduresReportes.obtenerRutasOParadasOEmpresas(storeProcedure);
            foreach (DataRow fila in tablaEmpresas.Rows)
            {
                empresas.Items.Add(fila.ItemArray[1].ToString());
            }
            return empresas;

        }
        public ComboBox obtenerRutas(ComboBox listaRutas)
        {
            String storeProcedure = "obtenerRutas";
             rutas = proceduresReportes.obtenerRutasOParadasOEmpresas(storeProcedure);
            foreach (DataRow fila in rutas.Rows)
            {
                listaRutas.Items.Add(fila.ItemArray[1].ToString());
            }
            return listaRutas;

        }



        public bool crearRuta(string nombre, int tarifa, CheckedListBox listaParadas)
        {
            bool validar = false;
            String sp = "insertarParadaPorRuta";
            String validarDatos = validarDatosRuta(nombre, tarifa, listaParadas);
            if (validarDatos.Equals("Datos correctos"))
            {
                String SP = "insertarRuta";
                int id = proceduresRutas.insertarRuta(SP, nombre, tarifa, empresa.getCedula());

                for (int i = 0; i < listaParadas.Items.Count; i++)
                {
                    if (listaParadas.GetItemChecked(i))
                    {
                        DataRow l = paradas.Rows[i];
                        int idParada = Convert.ToInt32(l.ItemArray[1].ToString());
                        proceduresRutas.modificarParadaPorRuta(id, idParada, sp);
                    }

                }
                       
                empresa.agregarRuta(id, nombre, tarifa);
                MessageBox.Show("Se ha registrado correctamente");
                validar = true;
               
            }
            return validar;
        }
        public String validarDatosRuta(String nombre, int tarifa, CheckedListBox listaParadas)
        {
            String mensaje = "Datos correctos";
            bool verificarDatos = true;
            if (nombre.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre de la ruta");
                verificarDatos = false;
            }
            if (tarifa < 100)
            {
                MessageBox.Show("La tarifa debe ser mayor a 100");
                verificarDatos = false;
            }
            if (listaParadas.SelectedItems.Count < 0)
            {
                MessageBox.Show("Debe eligir las paradas");
                verificarDatos = false;
            }

            if (!verificarDatos)
            {
                mensaje = "Datos Incorrectos";
            }

            return mensaje;
        }


        public String validarDatosEmpresa(String nombreEmpresa, long cedJuridica, long cuenta, String clave)
        {
            String mensaje = "Datos correctos";
            bool verificarDatos = true;
            if (nombreEmpresa.Equals(""))
            {
                MessageBox.Show("Debe ingresar el nombre de la empresa");
                verificarDatos = false;
            }
            if (cedJuridica.ToString().Length < 10 || cedJuridica.ToString().Length > 12)
            {
                MessageBox.Show("La cedula debe contener 10 o 12 digitos");
                verificarDatos = false;
            }
            if (cuenta.ToString().Length != 15)
            {
                MessageBox.Show("La cuenta debe contener 15 digitos");
                verificarDatos = false;
            }

            if (!verificarDatos)
            {
                mensaje = "Datos Incorrectos";
            }

            return mensaje;
        }
        public String validarDatosAutobus(int placa, String modelo, int capacidad)
        {
            String mensaje = "Datos correctos";
            bool verificarDatos = true;
           

            if (modelo.Equals(""))
            {
                MessageBox.Show("Debe ingresar el modelo del autobus");
                verificarDatos = false;
            }
            if(capacidad.ToString().Length > 240)
            {
                MessageBox.Show("La capacidad no puede ser superior a 240");
                verificarDatos = false;
            }
            if(placa.ToString().Length != 6)
            {
                MessageBox.Show("La placa no puede tener mas de 6 digitos");
                verificarDatos = false;
            }

            if (!verificarDatos)
            {
                mensaje = "Datos Incorrectos";
            }

            return mensaje;
        }
        public String getUsuario()
        {
            return conexion.getUsuario();
        }
        public String getNombreEmpresa()
        {
            return empresa.getNombre();
        }
        public long getCuenta()
        {
            return empresa.getCuenta();
        }

    }
}
