using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa1
{
    interface IVisitante
    {
        // Un método visitar para cada tipo de elemento
        void Visitar(Elemento pElemento);
        void Visitar(ElementoL pElemento);
    }
}
