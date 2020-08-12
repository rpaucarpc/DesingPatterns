using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CarroceriaBasica : ICarroceria
    {
        public string Caracteristicas()
        {
            return "Carroceria de metal";
        }
    }
}
