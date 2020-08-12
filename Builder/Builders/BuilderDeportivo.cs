using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuilderDeportivo : IBuilder
    {
        private Producto producto = new Producto();

        public void ConstruyeCarroceria()
        {
            producto.ColocarCarroceria( new CarroceriaEspecial() );
        }

        public void ConstruyeLlantas()
        {
            producto.ColocarLlantas( new LlantasSuper() );
        }

        public void ConstruyeMotor()
        {
            producto.ColocarMotor( new MotorGrande() );
        }

        public Producto ObtenProducto()
        {
            return producto;
        }
    }
}
