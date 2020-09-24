using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa2
{
    public class EmpresaSinFilial : Empresa
    {
        public EmpresaSinFilial(string pNombre, string pEmail, string pDireccion)
            : base(pNombre, pEmail, pDireccion)
        {

        }

        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
        }

        public override bool AgregaFilial(Empresa filial)
        {
            return false;
        }
    }
}
