using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterExa2
{
    public abstract class OperadorBinario : Expresion
    {
        protected Expresion operandoIzquierdo, operandoDerecho;

        protected OperadorBinario( Expresion pOperandoIzquierdo, Expresion pOperandoDerecho)
        {
            operandoDerecho = pOperandoDerecho;
            operandoIzquierdo = pOperandoIzquierdo;
        }
    }
}
