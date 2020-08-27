using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa01
{
    public class CNitrogeno : IComponente
    {
        // Variable de referencia hacia quien decoramos
        private IComponente decoramosA;
        public CNitrogeno(IComponente pComponente)
        {
            decoramosA = pComponente;
        }

        public double Costo()
        {
            //Calculamos el costo
            // El costo de lo que decoro mas mi costo como componente
            return decoramosA.Costo() + 4500;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }

       public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + decoramosA.ToString();
        }
    }
}
