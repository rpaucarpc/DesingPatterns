using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public class DocumentacionHtml : Documentacion
    {
        public override void AgregaDocumento(string documento)
        {
            if (documento.StartsWith("<HTML>"))
            {
                contenido.Add(documento);
            }
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentacion HTML");
            foreach (string item in contenido)
            {
                Console.WriteLine(item);
            }
        }
    }
}
