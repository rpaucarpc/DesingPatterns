using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public class FabricaVehiculoElectricidad : IFabricaVehiculo
    {
        public Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilElectricidad(modelo, color, potencia, espacio);
        }

        public Scooter CreaScooter(string modelo, string color, int potencia)
        {
            return new ScooterElectricidad(modelo, color, potencia);
        }
    }
}
