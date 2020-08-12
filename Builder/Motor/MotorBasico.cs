using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MotorBasico : IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 4 cilindros";
        }
    }
}
