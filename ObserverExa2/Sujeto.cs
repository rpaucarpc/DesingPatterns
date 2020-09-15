using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa2
{
    public abstract class Sujeto
    {
        protected IList<IObservador> observadores = new List<IObservador>();

        public void Agrega(IObservador pObservador)
        {
            observadores.Add(pObservador);
        }

        public void Suprime(IObservador pObservador)
        {
            observadores.Remove(pObservador);
        }

        public void Notifica()
        {
            foreach (IObservador observador in observadores)
            {
                observador.Actualiza();
            }
        }
    }
}
