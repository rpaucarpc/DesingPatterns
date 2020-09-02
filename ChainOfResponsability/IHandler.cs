using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public interface IHandler
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
