using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa2
{
    public class PedidoEntregado : EstadoPedido
    {
        public PedidoEntregado(Pedido pedido):base(pedido)
        {

        }
        public override void AgregaProducto(Producto producto)
        {
        }

        public override void Borrar()
        {
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return this;
        }

        public override void SuprimeProducto(Producto producto)
        {

        }
    }
}
