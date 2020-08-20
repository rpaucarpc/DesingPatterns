using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa2
{
    public class FormHtmlImpl : IFormularioImpl
    {
        public string AdministraZonaIndicada()
        {
            return Console.ReadLine();
        }

        public void DibujaTexto(string texto)
        {
            Console.WriteLine("HTML: " + texto);
        }
    }
}
