using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa1
{
    class Visitante : IVisitante
    {

        public int Conteo { get; set; }
        public int Clasificaciones { get; set; }
        public double Total { get; set; }

        public void ContarElementos(Elemento pElemento)
        {
            // Nos mandamos como visitante al elemento
            pElemento.Aceptar(this);

            // Vemos si tenemos hijo
            if (pElemento.hijo != null)
                ContarElementos(pElemento.hijo);

            // Vemos si tenemos siguiente
            if (pElemento.siguiente != null)
                ContarElementos(pElemento.siguiente);
        }

        public void Visitar(Elemento pElemento)
        {
            Conteo++;
            Total += pElemento.Costo;
        }

        public void Visitar(ElementoL pElemento)
        {
            Clasificaciones++;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("No conteo");
        }
    }
}
