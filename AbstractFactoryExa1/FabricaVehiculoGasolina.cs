using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public class FabricaVehiculoGasolina : IFabricaVehiculo
    {
        public Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio)
        {
            return new AutomovilGasolina(modelo, color, potencia, espacio);
        }

        public Scooter CreaScooter(string modelo, string color, int potencia)
        {
            return new ScooterGasolina(modelo, color, potencia);
        }
    }
}
