using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa1
{
    public class CAuto : IPrototipo
    {
        private int costo;
        public string Modelo { get; set; }

        public CAuto( string pModelo, int pCosto)
        {
            Modelo = pModelo;
            costo = pCosto;
        }

        public override string ToString()
        {
            return string.Format("Auto: {0}, {1}", Modelo, costo);
        }
        public object Clonar()
        {
            CAuto clon = new CAuto(Modelo, costo);
            return clon;
        }
    }
}
