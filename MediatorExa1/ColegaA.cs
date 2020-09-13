using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MediatorExa1
{
    public class ColegaA : IColega
    {
        private Mediador mediador;
        private string nombre;

        public ColegaA(string pNombre, Mediador pMediador)
        {
            nombre = pNombre;
            mediador = pMediador;

            // NOs sucribimos
            mediador.Suscribir(Recibir);
        }
        public void Enviar(string mensaje)
        {
            // Aqui colocamos la logica para el envio de mensaje
            // No necesariamente debe ser un parametro
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, envio: {1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }

        public void Recibir(string emisor, string mensaje)
        {
            // Lleva a cabo la recpcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }
    }
}
