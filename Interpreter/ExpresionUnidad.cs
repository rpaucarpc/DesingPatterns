using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionUnidad : Expresion
    {

        public override string Unidad()
        {
            // Regresamos el caracter para que sea utilizado por el 
            // interprete para reconocer y evaluar el valor
            return "I";
        }
        public override string Cuatro()
        {
            return "IV";
        }
        public override string Cinco()
        {
            return "V";
        }
        public override string Nueve()
        {
            return "IX";
        }
        public override int Factor()
        {
            // el valor encontrado sera multiplicado por 1
            // en el interprete
            return 1;
        }
    }
}
