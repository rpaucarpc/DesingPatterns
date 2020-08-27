using Subsistemas;
using System;

namespace FacadeExa01
{
    class Program
    {
        static void Main(string[] args)
        {
            CFachada fachada = new CFachada();

            fachada.Compra();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");
        }
    }
}
