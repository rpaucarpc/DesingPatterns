using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExa2
{
    public class EmpresaSinFilial : Empresa
    {
        public override bool AgregaFilial(Empresa filial)
        {
            return false;
        }

        public override double CalculaCosteMantenimiento()
        {
            return nVehiculo * costeUnitarioVehiculo;
        }
    }
}
