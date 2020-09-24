using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa1
{
    class Elemento : IElemento
    {
        public Elemento siguiente;
        public Elemento hijo;

        public double Costo{ get; set; }
        public string Nombre{ get; set; }

        public Elemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }
        public Elemento(double pCosto, string pNombre, Elemento pSiguiente)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento creado con siguiente {0} -> ${1}", pNombre, pCosto);
            siguiente = pSiguiente;
            Costo = pCosto;
            Nombre = pNombre;
        }

        // Aceptamos al visitante
        public virtual void Aceptar(IVisitante pVisitante)
        {
            // Nos mandamos como parametro para que el visitante
            // procese lo necesario
            pVisitante.Visitar(this);
        }
    }
}
