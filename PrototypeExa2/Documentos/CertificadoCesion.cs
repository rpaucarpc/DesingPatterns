using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public class CertificadoCesion : Documento
    {
        public override void Imprime()
        {
            Console.WriteLine("Imprime el certificado de Cesión: {0}", contenido);
        }

        public override void Visualiza()
        {
            Console.WriteLine("Muestra el certificado de Cesión: {0}", contenido);
        }
    }
}
