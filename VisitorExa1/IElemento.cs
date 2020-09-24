using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa1
{
    interface IElemento
    {
        void Aceptar(IVisitante pVisitante);
    }
}
