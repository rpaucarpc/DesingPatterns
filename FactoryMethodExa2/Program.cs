using System;

namespace FactoryMethodExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Cliente cliente;
            cliente = new ClienteContado();
            cliente.NuevoPedido(2000.0);
            cliente.NuevoPedido(10000.0);

            Console.WriteLine("--------------------------");
            cliente = new ClienteCredito();
            cliente.NuevoPedido(2000.0);
            cliente.NuevoPedido(10000.0);
        }
    }
}
