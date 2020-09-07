using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterExa2
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave( string pPalabraClave)
        {
            palabraClave = pPalabraClave;
        }

        public override bool Evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;

        }

        // parte análisis sintáctico
        public static new Expresion Parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            SiguientePieza();
            return resultado;
        }
    }
}
