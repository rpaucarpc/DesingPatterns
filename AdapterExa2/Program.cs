using System;

namespace AdapterExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");

            IDocumento documento = new DocumentoHtml();
            documento.Contenido = "Hello";
            documento.Dibuja();
            documento.Imprime();

            Console.WriteLine("-----------------");

            documento = new DocumentoPdf();
            documento.Contenido = "Hola";
            documento.Dibuja();
            documento.Imprime();
            
        }
    }
}
