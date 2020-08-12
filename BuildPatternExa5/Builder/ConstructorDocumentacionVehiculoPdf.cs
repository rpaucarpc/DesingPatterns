using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPatternExa5
{
    public class ConstructorDocumentacionVehiculoPdf : ConstructorDocumentacionVehiculo
    {
        public ConstructorDocumentacionVehiculoPdf()
        {
            documentacion = new DocumentacionPdf();
        }
        public override void ConstruyeSolicitudMatriculacion(string nombreSolicitante)
        {
            string documento;
            documento = string.Format("<PDF>Solicitud de pedido Cliente: {0} </PDF>", nombreSolicitante);
            documentacion.AgregaDocumento(documento);
        }

        public override void ConstruyeSolicitudPedido(string nombreCliente)
        {
            string documento;
            documento = string.Format("<PDF>Solicitud de matriculacion solicitante: {0}</PDF>", nombreCliente);
            documentacion.AgregaDocumento(documento);
        }
    }
}
