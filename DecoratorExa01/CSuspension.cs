using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa01
{
    public class CSuspension : IComponente
    {
        private IComponente decoramosA;
        public CSuspension(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempeño\r\n" + decoramosA.ToString();
        }
        public double Costo()
        {
            return decoramosA.Costo() + 63212;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Elevando suspension";
        }
    }
}
