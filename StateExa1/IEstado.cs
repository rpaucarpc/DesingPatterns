using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa1
{
    interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }
}
