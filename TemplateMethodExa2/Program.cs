using System;

namespace TemplateMethodExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedidoEspania = new PedidoEspania();
            pedidoEspania.SetImporteSinIVA(100000);
            pedidoEspania.CalculaPrecioConIVA();
            pedidoEspania.Visualiza();


            Pedido pedidoLuxembugo = new PedidoLuxemburgo();
            pedidoLuxembugo.SetImporteSinIVA(10000);
            pedidoLuxembugo.CalculaPrecioConIVA();
            pedidoLuxembugo.Visualiza();
        }
    }
}
