using System;

namespace DecoratorExa02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            IComponenteGraficoVehiculo vistaVehiculo = new VistaVehiculo();
            vistaVehiculo.Visualiza();

            Console.WriteLine("--------------------");

            vistaVehiculo = new ModeloDecorador(vistaVehiculo);

            vistaVehiculo.Visualiza();

            Console.WriteLine("--------------------");
            vistaVehiculo = new MarcaDecorador(vistaVehiculo);

            vistaVehiculo.Visualiza();

        }
    }
}
