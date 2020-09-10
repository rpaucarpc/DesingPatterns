using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa2
{
    public class Vehiculo : Elemento
    {
        public Vehiculo(string pDescripcion): base(pDescripcion)
        {

        }

        public void Visualiza()
        {
            Console.WriteLine("Descripción del vehículo: " + descripcion);
        }
    }
}
