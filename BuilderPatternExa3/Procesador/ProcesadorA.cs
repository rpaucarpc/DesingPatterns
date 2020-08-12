using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternExa3
{
    public class ProcesadorA : IProcesador
    {
        public string Caracteristica()
        {
            return "Intel Atom 3.5 Ghz";
        }
    }
}
