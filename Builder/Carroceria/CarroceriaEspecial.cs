using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarroceriaEspecial : ICarroceria
    {
        public string Caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }
}
