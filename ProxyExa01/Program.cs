using System;

namespace ProxyExa01
{
    class Program
    {
        static void Main(string[] args)
        {
            //CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            //miProxy.Peticion(1);
            //Console.WriteLine("------------");
            //miProxy.Peticion(2);

            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();
            miProxyS.Peticion(1);
            Console.WriteLine("------------");
            miProxyS.Peticion(2);
        }
    }
}
