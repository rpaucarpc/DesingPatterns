using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        public void ColocarMotor(IMotor pMotor)
        {
            motor = pMotor;
            Console.WriteLine("Se ha colocado el motor: {0}", motor.Especificaciones() );
        }

        public void ColocarCarroceria(ICarroceria pCarroceria)
        {
            carroceria = pCarroceria;
            Console.WriteLine("Se ha colocado la carroceria: {0}", carroceria.Caracteristicas() );
        }

        public void ColocarLlantas( ILlantas pLlantas)
        {
            llantas = pLlantas;
            Console.WriteLine("Se ha colocado las llantas: {0}", llantas.Informacion() );
        }

        public void MostrarAuto()
        {
            Console.WriteLine("Tu auto tiene {0}, {1}, {2}", motor.Especificaciones(), llantas.Informacion(), carroceria.Caracteristicas() );
        }


    }
}
