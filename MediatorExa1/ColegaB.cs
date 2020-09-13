using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa1
{
    public class ColegaB : IColega
    {
        private Mediador mediador;
        private string nombre;
        private int conteo;

        public ColegaB(string pNombre, Mediador pMediador)
        {
            mediador = pMediador;
            nombre = pNombre;

            mediador.Suscribir(Recibir);
        }
        public void Enviar(string mensaje)
        {
            // Aqui colocamos la logica para el envio de mensaje
            // no necesariamente debe ser un parametro
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->[{0}]:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }

        public void Recibir(string emisor, string mensaje)
        {
            conteo ++;
            // Lleva a cabo la recepcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<-[{0}, {1}]({2}): {3}", nombre, emisor, conteo, mensaje);
        }
    }
}
