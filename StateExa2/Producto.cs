using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa2
{
    public class Producto
    {
        protected string nombre;
        public Producto(string pNombre)
        {
            nombre = pNombre;
        }

        public void Visualiza()
        {
            Console.WriteLine("Producto: " + nombre);
        }
    }
}
