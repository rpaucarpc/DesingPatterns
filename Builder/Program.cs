using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************");
            Director director = new Director();

            //Construimos un auto economico
            BuilderNormal normal = new BuilderNormal();
            director.Contruye(normal);

            Producto auto1 = normal.ObtenProducto();
            auto1.MostrarAuto();
            Console.WriteLine("--------------------");

            //Construimos un auto deportivo
            BuilderDeportivo deportivo = new BuilderDeportivo();
            director.Contruye(deportivo);

            Producto auto2 = deportivo.ObtenProducto();
            auto2.MostrarAuto();
        }
    }
}
