using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightExa2
{
    public class OpcionVehiculo
    {
        protected string nombre;
        protected string descripcion;
        protected int precioEstandar;

        public OpcionVehiculo(string nombre)
        {
            this.nombre = nombre;
            this.descripcion = "Descripción de " + nombre;
            this.precioEstandar = 100;
        }

        public void Visualiza(int precioVenta)
        {
            Console.WriteLine("Opción");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Descripcion");
            Console.WriteLine("Precion estándar: " + precioEstandar);
            Console.WriteLine("Precion de venta: " + precioVenta);
        }
    }
}
