using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public class Vendedor
    {
        protected ConstructorDocumentacionVehiculo constructor;

        public Vendedor(ConstructorDocumentacionVehiculo pConstructor)
        {
            constructor = pConstructor;
        }

        public Documentacion Construye(string nombreCliente)
        {
            constructor.ConstruyeSolicitudMatriculacion(nombreCliente);
            constructor.ConstruyeSolicitudPedido(nombreCliente);
            return constructor.resultado();
        }
    }
}
