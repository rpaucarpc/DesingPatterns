using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SingletonPatternEx2
{
    public sealed class Comercial
    {
        private static readonly Comercial instance = new Comercial();

        public string Nombre { get; set; }
        public string Direccion{ get; set; }
        public string Email{ get; set; }

        private Comercial()
        {

        }

        public static Comercial Instance 
        {
            get
            {
                return instance;
            }
        }

        public void Visualiza()
        {
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Dirección: {0}", Direccion);
            Console.WriteLine("Email: {0}", Email);
        }

    }
}
