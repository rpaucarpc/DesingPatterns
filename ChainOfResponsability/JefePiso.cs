using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class JefePiso : IHandler
    {
        private IHandler siguiente = null;

        public JefePiso(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el jefe de piso");

            // Si son mas de 100 articulos o mas de 75 000 en ventas
            // pasa al propietario
            double total = pCantidad * pPrecio;

            if (pCantidad > 100 || total > 75000)
            {
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            }
            else
            {
                //Damos el 10% de descuento
                if (pCantidad > 20)
                {
                    total *= 0.9;
                }
            }
            return total;
        }
    }
}
