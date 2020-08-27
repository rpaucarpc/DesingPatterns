using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa01
{
    public class CSistemaSonido : IComponente
    {
        private IComponente decoramosA;
        public CSistemaSonido( IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "RAdio 350XZ+\r\n" + decoramosA.ToString();
        }

        public double Costo()
        {
            return decoramosA.Costo() + 3500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Enciende el radio";
        }
    }
}
