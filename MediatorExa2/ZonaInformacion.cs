using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa2
{
    public class ZonaInformacion : Control
    {
        public ZonaInformacion( string nombre):base(nombre)
        {

        }
        public override void Informa()
        {
            Console.WriteLine("Informacion de: " + Nombre);
            Valor = Console.ReadLine();
            this.Modifica();

        }
    }
}
