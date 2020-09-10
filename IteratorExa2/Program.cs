using System;

namespace IteratorExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalagoVehiculo catalogo = new CatalagoVehiculo();
            IteradorVehiculo iterador = catalogo.Busqueda("economico");
            Vehiculo vehiculo;
            iterador.Inicio();
            vehiculo = iterador.Item();

            while(vehiculo != null)
            {
                vehiculo.Visualiza();
                iterador.Siguiente();
                vehiculo = iterador.Item();
            }
        }
    }
}
