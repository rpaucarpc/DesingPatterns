using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorExa2
{
    public class EmpresaMadre : Empresa
    {
        protected IList<Empresa> filiales = new List<Empresa>();
        public EmpresaMadre(string pNombre, string pEmail, string pDireccion)
            :base(pNombre, pEmail, pDireccion)
        {

        }
        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
            foreach (Empresa filial in filiales)
                filial.AceptaVisitante(visitante);
        }

        public override bool AgregaFilial(Empresa filial)
        {
            filiales.Add(filial);
            return true;
        }
    }
}
