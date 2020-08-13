using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa2
{
    public class OrdenPedido : Documento
    {
        public override void Imprime()
        {
            Console.WriteLine("Imprime la orden de pedido: {0}", contenido);
        }

        public override void Visualiza()
        {
            Console.WriteLine("Muestra la orden de pedido: {0}", contenido);
        }
    }
}
