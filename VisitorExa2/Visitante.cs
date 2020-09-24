using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa2
{
    public interface IVisitante
    {
        void Visita(EmpresaSinFilial empresa);
        void Visita(EmpresaMadre empresa);
    }
}
