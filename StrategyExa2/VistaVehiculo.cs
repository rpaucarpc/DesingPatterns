using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa2
{
    public class VistaVehiculo
    {
        protected string descripcion;
        public VistaVehiculo(string pDescripcion)
        {
            descripcion = pDescripcion;
        }

        public void Dibuja()
        {
            Console.Write(descripcion);
        }
    }
}
