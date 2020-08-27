using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExa02
{
    public interface IWebServiceAuto
    {
        string Documento(int indice);
        IList<string> BuscaVehiculos(int precioMedio, int desviacionMax);
    }
}
