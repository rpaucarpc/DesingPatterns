using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    public class CSistemaCompra
    {
        public bool Comprar()
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir número de tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago rechazado");
                return false;
            }
        }
    }
}
