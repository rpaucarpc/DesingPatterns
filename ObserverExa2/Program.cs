using System;

namespace ObserverExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Descripcion = "Vehiculo económico";
            vehiculo.Precio = 5000.0;

            VistaVehiculo vistaVehiculo = new VistaVehiculo(vehiculo);
            vistaVehiculo.Redibuja();
            vehiculo.Precio = 4500.0;


            VistaVehiculo vistaVehiculo2 = new VistaVehiculo(vehiculo);
            vehiculo.Precio = 5500.0;
        }
    }
}
