using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightExa01
{
    public interface IFlyweight
    {
        void ColocaNombre(string pNombre);
        void CalcularCosto();
        void Mostrar();
        string ObtenerNombre();
    }
}
