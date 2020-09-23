using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExa1
{
    class CDiv : IOperacion
    {
        public double Operacion(double a, double b)
        {
            return a / b;
        }
    }
}
