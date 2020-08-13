using System;

namespace FactoryMethodExa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienes para tu vehiculo?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //Obtenemos el vehiculo de la fábrica
            vehiculo = CCreador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();
        }
    }
}
