using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa1
{
    // Si vamos a tener varios sujetos se puede crear una interfaz ISujeto
    public class Sujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rnd = new Random();
        private int n;

        public int N { get => n; set => n = value; }

        public void Suscribirse(IObservador suscrito)
        {
            // lo adicionamos a la lista
            observadores.Add(suscrito);
        }

        public void Desuscribir(IObservador suscrito)
        {
            // Recomendable poner codigo de seguridad
            observadores.Remove(suscrito);
        }

        private void Notificar()
        {
            // Notificamos el nuevo estado a todos los observadores
            // que esten suscritos
            foreach (IObservador o in observadores )
            {
                //o.Update(mensaje);
                o.UpdatePull();
            }
        }

        // Aqui simulamos el trabajo del observador y un cambio de estado
        // que necesita ser notificado
        public void Trabajo()
        {
            n = rnd.Next(10);

            if (n%2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Nuevo estado valido ---");
                mensaje = string.Format("El nuevo valor es {0}", n);
                Notificar();
            }
        }
    }
}
