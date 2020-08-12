using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public class ConstructorDocumentacionVehiculoHtml : ConstructorDocumentacionVehiculo
    {
        public ConstructorDocumentacionVehiculoHtml()
        {
            documentacion = new DocumentacionHtml();
        }
        public override void ConstruyeSolicitudMatriculacion(string nombreSolicitante)
        {
            string documento;
            documento = string.Format("<HTML>Solicitud de pedido Cliente: {0} </HTML>",nombreSolicitante);
            documentacion.AgregaDocumento(documento);
        }

        public override void ConstruyeSolicitudPedido(string nombreCliente)
        {
            string documento;
            documento = string.Format("<HTML>Solicitud de matriculacion solicitante: {0}</HTML>", nombreCliente);
            documentacion.AgregaDocumento(documento);
        }
    }
}
