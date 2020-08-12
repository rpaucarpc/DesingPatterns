using System;

namespace BuildPatternExa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");

            ConstructorDocumentacionVehiculo constructor = new ConstructorDocumentacionVehiculoHtml();

            Vendedor vendedor = new Vendedor(constructor);
            Documentacion documentacion = vendedor.Construye("Rolando");
            documentacion.Imprime();

            Console.WriteLine("--------------------------------");

            constructor = new ConstructorDocumentacionVehiculoPdf();
            vendedor = new Vendedor(constructor);
            documentacion = vendedor.Construye("Rolando");
            documentacion.Imprime();

        }
    }
}
