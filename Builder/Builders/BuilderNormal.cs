﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstruyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstruyeLlantas()
        {
            auto.ColocarLlantas(new LlantasDoce());
        }

        public void ConstruyeMotor()
        {
            auto.ColocarMotor(new MotorBasico() );
        }
        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
