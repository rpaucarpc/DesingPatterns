using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa2
{
    public class PedidoEnCurso : EstadoPedido
    {
        public PedidoEnCurso(Pedido pedido) : base(pedido)
        {

        }
        public override void AgregaProducto(Producto producto)
        {
            pedido.Productos.Add(producto);
        }

        public override void Borrar()
        {
            pedido.Productos.Clear();
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoValidado(pedido);
        }

        public override void SuprimeProducto(Producto producto)
        {
            pedido.Productos.Remove(producto);
        }
    }
}
