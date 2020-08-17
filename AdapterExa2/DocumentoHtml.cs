using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterExa2
{
    public class DocumentoHtml : IDocumento
    {
        public string Contenido { get; set; }

        public void Dibuja()
        {
            Console.WriteLine("Dibuja el documento Html: {0}", Contenido);
        }

        public void Imprime()
        {
            Console.WriteLine("Imprime el documento Html: {0}", Contenido);
        }
    }
}
