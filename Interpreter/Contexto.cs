using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Interpreter
{
    class Contexto
    {
        public string Expresion{ get; set; }
        public int Valor{ get; set; }

        // Colocamos la expresion a interpretar
        public Contexto(string pExpresion)
        {
            Expresion = pExpresion;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Se evaluara {0}", Expresion);
        }
    }
}
