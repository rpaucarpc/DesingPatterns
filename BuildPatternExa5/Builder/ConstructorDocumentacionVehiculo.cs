using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public abstract class ConstructorDocumentacionVehiculo
    {
        protected Documentacion documentacion;

        public abstract void ConstruyeSolicitudPedido(string nombreCliente);
        public abstract void ConstruyeSolicitudMatriculacion(string nombreSolicitante);

        public Documentacion resultado()
        {
            return documentacion;
        }
    }
}
