using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloCompañia
{
    class Empresa
    {
        String nombre;
        long cedulaJuridica;
        long numCuenta;
        String password;
        List<Autobus> autobuses = new List<Autobus>();
        List<Ruta> rutas = new List<Ruta>();
        DataTable tablaRuta;

        public Empresa()
        {
           
        }
        public Empresa(String nombreEmpresa, long cedJuridica, long cuenta, String clave)
        {
            nombre = nombreEmpresa;
            cedulaJuridica = cedJuridica;
            numCuenta = cuenta;
            password = clave;
        }

        public void setNombre(String n)
        {
            nombre = n;
        }
        public void setCedula(long cedula)
        {
            cedulaJuridica = cedula;
        }
        public void setCuenta(long cuenta)
        {
            numCuenta = cuenta;
        }
        public void setPassword(String pass)
        {
            password = pass;
        }
        public void setTablaRutas(DataTable tabla)
        {
            tablaRuta = tabla;
        }
        public long getCedula()
        {
            return cedulaJuridica ;
        }
        public DataTable getTablaRutas()
        {
            return tablaRuta;
        }
        public long getCuenta()
        {
            return numCuenta;
        }
        public String getPassword()
        {
            return password;
        }
        public String getNombre()
        {
            return nombre;
        }

        public void agregarAutobus(int placa, String modelo, int capacidad)
        {
            Autobus bus = new Autobus(placa, modelo, capacidad);
            autobuses.Add(bus);
        }
        public void agregarRuta(int id, String nombre, int tarifa)
        {
            Ruta nueva = new Ruta(id, nombre, tarifa);
            rutas.Add(nueva);
        }
        public int cantidadBuses()
        {
            return autobuses.Count();
        }
        public List<Autobus> getAutobuses()
        {
            return autobuses;
        }
        public List<Ruta> getRutas()
        {
            return rutas;
        }

    }
    


}
