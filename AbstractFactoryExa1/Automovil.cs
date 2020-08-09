using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa1
{
    public abstract class Automovil
    {
        protected string modelo;
        protected string color;
        protected int potencia;
        protected double espacio;
        public Automovil(string pModelo, string pColor, int pPotencia, double pEspacio)
        {
            modelo = pModelo;
            color = pColor;
            potencia = pPotencia;
            espacio = pEspacio;
        }

        public abstract void MostrarCaracteristicas();
    }
}
