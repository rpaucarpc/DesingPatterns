using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public class ScooterGasolina : Scooter
    {
        public ScooterGasolina(string pModelo, string pColor, int pPotencia)
            : base(pModelo, pColor, pPotencia) { }
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Scooter de Gasolina de modelo: {0} de color: {1} de potencia {2} ", modelo, color, potencia);
        }
    }
}
