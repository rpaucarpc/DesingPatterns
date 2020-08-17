using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class CAdaptador : ITarget
    {
        CCalculadoraArray adaptado = new CCalculadoraArray();
        public int Sumar(int pA, int pB)
        {
            double r = 0;
            int[] operadores = { pA, pB };
            r = adaptado.Suma(operadores);
            return (int)r;
        }
    }
}
