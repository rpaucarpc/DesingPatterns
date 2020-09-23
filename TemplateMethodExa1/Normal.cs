using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa1
{
    class Normal : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Pintar logotipo");
            Console.WriteLine("Poner brillos");
            Console.WriteLine("Adicionar cromos");
            return 7.50 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hacer {0} veces", cantidad);
            Console.WriteLine("Preparar caja");
            Console.WriteLine("Poner instructivo");
            Console.WriteLine("Poner garantia");
            Console.WriteLine("Meter en caja con empaque");
            Console.WriteLine("Sellar Caja");

            return 12.50 * cantidad;
        }
    }
}
