using System;
using System.Reflection;

namespace IteratorExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            CContenedora datos = new CContenedora();

            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
