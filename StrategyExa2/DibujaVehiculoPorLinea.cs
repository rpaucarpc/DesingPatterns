using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa2
{
    public class DibujaVehiculoPorLinea : IDibujaCatalogo
    {
        public void Dibuja(IList<VistaVehiculo> contenido)
        {
            Console.WriteLine("Dibuja los vehiculos mostrando un vehiculo por linea");
            foreach(VistaVehiculo vistaVehiculo in contenido)
            {
                vistaVehiculo.Dibuja();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
