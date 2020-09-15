using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa1
{
    public class Observador : IObservador
    {
        private string nombre;
        private Sujeto sujeto;
        public Observador(string pNombre, Sujeto pSujeto)
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribirse(this);
        }
        // este metodo es usado por el sujeto en el push
        public void Update(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push, {0}-{1}", nombre, mensaje);
        }

        // Aqui es para el caso pull
        public void UpdatePull()
        {
            // Obtenemos del sujeto
            // puede ir mas logica para dicidir cuando hacerlo
            int n = sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pull, {0}-{1}", nombre, n);
        }
    }
}
