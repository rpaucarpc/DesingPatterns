using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa1
{
    public interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);

    }
}
