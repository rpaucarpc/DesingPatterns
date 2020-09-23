using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa1
{
    class Algoritmo
    {
        public double MetodoTemplate(IPrimitiva tipo, int cantidad)
        {
            double total = 0;

            // Crear juguete
            total += CrearJuguete(cantidad);

            // Lo decoramos
            total += tipo.Decorar(cantidad);


            // Verificamos calidad
            Calidad();

            // Empacamos
            total += tipo.Empacar(cantidad);

            return total;
        }

        private double CrearJuguete(int pCantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes ", pCantidad);
            return 16.50 * pCantidad;
        }

        private void Calidad()
        {
            Console.WriteLine("Pasa control de calidad");
        }
    }
}
