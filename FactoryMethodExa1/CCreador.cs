using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa1
{
    public class CCreador
    {
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;

            //Seleccionamos el tipo de instancia segun nuestras reglas.

            if (pDinero > 10000000)
            {
                temp = new CAvion();
            }
            else if (pDinero > 200000)
            {
                temp = new CAuto();
            }
            else
            {
                temp = new CBici();
            }
            return temp;
        }
    }
}
