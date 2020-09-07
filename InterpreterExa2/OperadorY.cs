using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterExa2
{
    public class OperadorY : OperadorBinario
    {
        public OperadorY(Expresion operandoIzquierdo, Expresion operandoDerecho) : base(operandoIzquierdo, operandoDerecho) { }

        public override bool Evalua(string descripcion)
        {
            return operandoIzquierdo.Evalua(descripcion) && operandoDerecho.Evalua(descripcion);
        }

        // parte análisis sintáctico
        public static new Expresion Parsea()
        {
            Expresion resultadoIzquierdo, resultadoDerecho;
            resultadoIzquierdo = Expresion.Parsea();
            while ( (pieza != null) && (pieza == "y") )
            {
                SiguientePieza();
                resultadoDerecho = Expresion.Parsea();
                resultadoIzquierdo = new OperadorY(resultadoIzquierdo, resultadoDerecho);
            }
            return resultadoIzquierdo;
        }
    }
}
