using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public abstract class Scooter
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        public Scooter(string pModelo, string pColor, int pPotencia)
        {
            modelo = pModelo;
            color = pColor;
            potencia = pPotencia;
        }
        public abstract void MostrarCaracteristicas();

    }
}
