using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public class ClienteCredito : Cliente
    {
        protected override Pedido CreaPedido(double importe)
        {
            return new PedidoCredito(importe);
        }
    }
}
