using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public interface IFabricaVehiculo
    {
        Automovil CreaAutomovil(string modelo, string color, int potencia, double espacio);
        Scooter CreaScooter(string modelo, string color, int potencia);
    }
}
