using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa2
{
    public class FormAppletImpl : IFormularioImpl
    {
        public string AdministraZonaIndicada()
        {
            return Console.ReadLine();
        }

        public void DibujaTexto(string texto)
        {
            Console.WriteLine("Applet: " + texto);
        }
    }
}
