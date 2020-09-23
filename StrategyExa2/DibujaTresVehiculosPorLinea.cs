using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa2
{
    public class DibujaTresVehiculosPorLinea : IDibujaCatalogo
    {
        public void Dibuja(IList<VistaVehiculo> contenido)
        {
            int contador;
            Console.WriteLine( "Dibuja los vehiculos mostrando tres vehiculos por linea");
            contador = 0;
            foreach (VistaVehiculo vistaVehiculo in contenido)
            {
                vistaVehiculo.Dibuja();
                contador++;
                if (contador == 3)
                {
                    Console.WriteLine();
                    contador = 0;
                }
                else
                {
                    Console.WriteLine(" ");
                }    
            }
            if (contador != 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
