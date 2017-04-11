using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloCompañia
{
    public class Autobus
    {
        int placa;
        String modelo;
        int capacidad;
        int estado;

        public Autobus(int numPlaca, String nombreModelo, int numCapacidad)
        {
            placa = numPlaca;
            modelo = nombreModelo;
            capacidad = numCapacidad;
            estado = 1;
        }
        public Autobus(int numPlaca, String nombreModelo, int numCapacidad, int estadoBus)
        {
            placa = numPlaca;
            modelo = nombreModelo;
            capacidad = numCapacidad;
            estado = estadoBus;
        }

        public int getPlaca()
        {
            return placa;
        }
        public String getModelo()
        {
            return modelo;
        }
        public int getCapacidad()
        {
            return capacidad;
        }
        public int getEstado()
        {
            return estado;
        }

    }
}
