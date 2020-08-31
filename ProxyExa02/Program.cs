using System;

namespace ProxyExa02
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimacion animacion = new AnimacionProxy();
            animacion.Dibuja();
            animacion.Clic();
            animacion.Dibuja();
        }
    }
}
