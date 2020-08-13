using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public class SolicitudMatriculacion : Documento
    {
        public override void Imprime()
        {
            Console.WriteLine("Imprime la solicitud de matriculación: {0}", contenido);
        }

        public override void Visualiza()
        {
            Console.WriteLine("Muestra la solicitud de matriculación: {0}", contenido);
        }
    }
}
