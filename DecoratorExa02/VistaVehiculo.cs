using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa02
{
    public class VistaVehiculo : IComponenteGraficoVehiculo
    {
        public void Visualiza()
        {
            Console.WriteLine("Visualizacion del vehiculo");
        }
    }
}
