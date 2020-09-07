using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionMIles : Expresion
    {
        public override string Unidad()
        {
            // Regresamos el caracter para que sea utilizado por el 
            // interprete para reconocer y evaluar el valor
            return "M";
        }
        public override string Cuatro()
        {
            return " ";
        }
        public override string Cinco()
        {
            return " ";
        }
        public override string Nueve()
        {
            return " ";
        }
        public override int Factor()
        {
            // el valor encontrado sera multiplicado por 1
            // en el interprete
            return 1000;
        }
    }
}
