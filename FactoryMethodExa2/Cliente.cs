using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public abstract class Cliente
    {
        protected IList<Pedido> pedidos = new List<Pedido>();

        protected abstract Pedido CreaPedido( double importe );

        public void NuevoPedido(double importe)
        {
            Pedido pedido = this.CreaPedido(importe);
            if (pedido.Valida())
            {
                pedido.Paga();
                pedidos.Add(pedido);
            }
        }
    }
}
