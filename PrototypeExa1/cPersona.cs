using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa1
{
    public class cPersona : IPrototipo
    {
        public int Edad { get; set; }
        public string Nombre{ get; set; }
        public cPersona( string pNombre, int pEdad)
        {
            Edad = pEdad;
            Nombre = pNombre;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Nombre, Edad);
        }
        public object Clonar()
        {
            cPersona clon= new cPersona(Nombre, Edad);
            return clon;
        }
    }
}
