using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloCompañia
{
    public class Ruta
    {
        
        String nombre;
        int tarifa;
        int id;
        int estado;

        public Ruta(int idRuta, String name, int numTarifa)
        {
            id = idRuta;
            nombre = name;
            tarifa = numTarifa;
            estado = 1;  
            
        }
        public Ruta(int idRuta, String name, int numTarifa, int estadoRuta)
        {
            id = idRuta;
            nombre = name;
            tarifa = numTarifa;
            estado = estadoRuta;

        }

        public int getTarifa()
        {
            return tarifa;
        }
        public int getId()
        {
            return id;
        }
        public int getEstado()
        {
            return estado;
        }
        public string getNombre()
        {
            return nombre;
        }
    }
}
