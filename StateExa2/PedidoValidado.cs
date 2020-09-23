using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa2
{
    public class PedidoValidado : EstadoPedido
    {
        public PedidoValidado(Pedido pedido) : base(pedido)
        {

        }
        public override void AgregaProducto(Producto producto)
        {
        }

        public override void Borrar()
        {
            pedido.Productos.Clear();
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoEntregado(pedido);
        }

        public override void SuprimeProducto(Producto producto)
        {
            
        }
    }
}
