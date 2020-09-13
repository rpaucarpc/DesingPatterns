using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa1
{
    public class Mediador
    {

        // Creamos un delegado que usaremos para invocar los metodos
        public delegate void DEnvio(string emisor, string mensaje);
        DEnvio enviarMensaje;

        // Adicionamos el metodo a invocar
        public void Suscribir(DEnvio metodo)
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---- Suscrito ---");

        }

        public void Enviar(string emisor, string mensaje)
        {
            // usamos el ediador para censurar
            if (mensaje.Contains("palabrota"))
                mensaje = mensaje.Replace("palabrota", "*****");

            // Enviamos los mensajes correspondientes via el delegado
            enviarMensaje(emisor, mensaje);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- mensajes enviados ---");
            
        }

        public void Bloqueo(DEnvio metodo)
        {
            enviarMensaje -= metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Bloqueo ---");
        }
    }
}
