using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionDecenas : Expresion
    {
        public override string Unidad()
        {
            // Regresamos el caracter para que sea utilizado por el 
            // interprete para reconocer y evaluar el valor
            return "X";
        }
        public override string Cuatro()
        {
            return "XL";
        }
        public override string Cinco()
        {
            return "L";
        }
        public override string Nueve()
        {
            return "XC";
        }
        public override int Factor()
        {
            // el valor encontrado sera multiplicado por 1
            // en el interprete
            return 10;
        }
    }
}
