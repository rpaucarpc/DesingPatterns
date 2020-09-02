using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la cadena
            Propietario propietario = new Propietario();
            JefePiso jefePiso = new JefePiso(propietario);
            Vendedor vendedor = new Vendedor(jefePiso);

            int cantidad = 150;
            double precio = 10000;
            double total = 0;

            total = vendedor.CalculaPrecioFinal(cantidad, precio);

            Console.WriteLine("Total {0}, con descuento {1}", cantidad * precio, total);
        }
    }
}
