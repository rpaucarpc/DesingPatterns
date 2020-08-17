using System;
using System.Net.Http.Headers;
using System.Xml.XPath;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            int resultado = 0;
            ITarget calcu = new CCalcu();
            resultado = calcu.Sumar(4,3);

            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine("------------------------");

            calcu = new CAdaptador();
            resultado = calcu.Sumar(5,6);
            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
