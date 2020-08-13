using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public class ClienteContado : Cliente
    {
        protected override Pedido CreaPedido(double importe)
        {
            return new PedidoContado(importe);
        }
    }
}
