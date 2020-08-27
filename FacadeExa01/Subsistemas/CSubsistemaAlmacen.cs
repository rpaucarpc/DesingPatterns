using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    public class CSubsistemaAlmacen
    {
        private int cantidad;
        public CSubsistemaAlmacen()
        {
            cantidad = 3;
        }

        public bool SacarAlmacen()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espera a que haya existencias");
                return false;
            }
        }
    }
}
