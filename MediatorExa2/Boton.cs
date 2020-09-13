using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa2
{
    public class Boton : Control
    {
        public Boton(string nombre) : base(nombre)
        {

        }
        public override void Informa()
        {
            Console.WriteLine("¿Desea activar el botón " + Nombre + "?");
            string respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                this.Modifica();
            }
        }
    }
}
