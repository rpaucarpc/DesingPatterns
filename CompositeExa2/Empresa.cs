using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExa2
{
    public abstract class Empresa
    {
        protected static double costeUnitarioVehiculo = 5.0;
        protected int nVehiculo;

        public void AgregaVehiculo()
        {
            nVehiculo += 1;
        }
        public abstract double CalculaCosteMantenimiento();
        public abstract bool AgregaFilial(Empresa filial);
    }
}
