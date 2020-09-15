using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa2
{
    public class VistaVehiculo : IObservador
    {
        protected Vehiculo vehiculo;
        protected string texto = "";
        public VistaVehiculo( Vehiculo pVehiculo)
        {
            vehiculo = pVehiculo;
            vehiculo.Agrega(this);
            ActualizaTexto();
        }

        protected void ActualizaTexto()
        {
            texto = "Descripcion " + vehiculo.Descripcion + " Precio: " + vehiculo.Precio;
        }
        public void Actualiza()
        {
            ActualizaTexto();
            this.Redibuja();
        }

        public void Redibuja()
        {
            Console.WriteLine(texto);
        }
    }
}
