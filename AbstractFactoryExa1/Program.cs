using System;

namespace AbstractFactoryExa1
{
    class Program
    {

        static void Main(string[] args)
        {
            IFabricaVehiculo fabrica;

            Console.WriteLine("================  VEhiculos electricos    =================");

            fabrica = new FabricaVehiculoElectricidad();

            Automovil automovil1 = fabrica.CreaAutomovil("estandar", "Azul", 1200, 3.2);
            automovil1.MostrarCaracteristicas();

            Scooter scooter1 = fabrica.CreaScooter("scooter standar","Linear",100);
            scooter1.MostrarCaracteristicas();


            Console.WriteLine("============== VEhiculos a Gasolina ===================");
            fabrica = new FabricaVehiculoGasolina();

            Automovil automovil2 = fabrica.CreaAutomovil("estandar", "Azul", 1200, 3.2);
            automovil2.MostrarCaracteristicas();

            Scooter scooter2 = fabrica.CreaScooter("scooter standar", "Linear", 100);
            scooter2.MostrarCaracteristicas();
        }
    }
}
