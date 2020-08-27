using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExa02
{
    public class WebServiceAutoImpl : IWebServiceAuto
    {
        protected ICatalogo catalogo = new ComponenteCatalogo();
        protected IGestionDocumento gestionDocumento = new ComponenteGestionDocumento();

        public IList<string> BuscaVehiculos(int precioMedio, int desviacionMax)
        {
            return catalogo.BuscaVehiculos(precioMedio - desviacionMax, precioMedio + desviacionMax);
        }

        public string Documento(int indice)
        {
            return gestionDocumento.Documento(indice);
        }

    }
}
