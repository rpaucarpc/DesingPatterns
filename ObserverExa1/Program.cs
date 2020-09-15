using System;

namespace ObserverExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el sujeto
            Sujeto miSujeto = new Sujeto();

            // Creamos a los observadores
            Observador a = new Observador("A", miSujeto);
            Observador b = new Observador("B", miSujeto);
            Observador c = new Observador("C", miSujeto);

            // trabajamos
            for (int i = 0; i < 5; i++)
            {
                miSujeto.Trabajo();
            }


            // Alguien se sale de la lista
            Console.WriteLine(" --- Desuscribirse ---");
            miSujeto.Desuscribir(b);

            // trabajamos
            for (int i = 0; i < 5; i++)
            {
                miSujeto.Trabajo();
            }


        }
    }
}
