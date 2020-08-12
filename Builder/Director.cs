using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        public void Contruye(IBuilder pConstructor)
        {
            pConstructor.ConstruyeMotor();
            pConstructor.ConstruyeCarroceria();
            pConstructor.ConstruyeLlantas();

        }
    }
}
