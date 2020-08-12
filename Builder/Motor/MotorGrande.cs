using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MotorGrande : IMotor
    {
        public string Especificaciones()
        {
            return "Motor de 8 cilindros";
        }
    }
}
