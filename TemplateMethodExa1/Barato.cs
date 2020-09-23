using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa1
{
    class Barato : IPrimitiva
    {
        public double Decorar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Pegar etiqueta");
            }

            return 1.5 * cantidad;
        }

        public double Empacar(int cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Meter en bolsa");
            }

            return 0.25 * cantidad;
        }
    }
}
