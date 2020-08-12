using System;

namespace BuilderPatternExa3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");

            Director director= new Director();

            IBuilder cpuGamaA= new CPUGamaAlta();

            director.Construye(cpuGamaA);

            Producto producto = cpuGamaA.ObtenerProducto();
            producto.Mostrar();
        }
    }
}
