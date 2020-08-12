using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public class DocumentacionPdf : Documentacion
    {
        public override void AgregaDocumento(string documento)
        {
            if (documento.StartsWith("<PDF>"))
            {
                contenido.Add(documento);
            }
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentacion PDF");
            foreach (string item in contenido)
            {
                Console.WriteLine(item);
            }
        }
    }
}
