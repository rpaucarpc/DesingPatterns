using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyExa02
{
    public class Video : IAnimacion
    {
        public void Clic(){ }

        public void Dibuja()
        {
            Console.WriteLine("Mostrar el video");
        }

        public void Carga()
        {
            Console.WriteLine("Cargar el video");
        }

        public void Reproduce()
        {
            Console.WriteLine("Reproducir el video");
        }
    }
}
