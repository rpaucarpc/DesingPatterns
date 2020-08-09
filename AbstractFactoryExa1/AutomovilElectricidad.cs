using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public class AutomovilElectricidad : Automovil
    {
        public AutomovilElectricidad(string pModelo, string pColor, int pPotencia, double pEspacio)
            : base(pModelo,pColor,pPotencia,pEspacio){}
        public override void MostrarCaracteristicas()
        {
            Console.WriteLine("Automóvil eléctrico de modelo: {0} de color: {1} de potencia {2} de espacio: {3}", modelo, color, potencia, espacio);

        }
    }
}
