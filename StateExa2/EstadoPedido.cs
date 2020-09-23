using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa2
{
    public abstract class EstadoPedido
    {
        protected Pedido pedido;
        public EstadoPedido(Pedido pPedido)
        {
            pedido = pPedido;
        }

        public abstract void AgregaProducto(Producto producto);
        public abstract void Borrar();
        public abstract void SuprimeProducto(Producto producto);
        public abstract EstadoPedido EstadoSiguiente();
    }
}
