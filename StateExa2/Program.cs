using System;

namespace StateExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.AgregaProducto(new Producto("vehiculo 1"));
            pedido.AgregaProducto(new Producto("accesorio 2"));
            pedido.Visualiza();
            pedido.EstadoSiguiente();
            pedido.AgregaProducto(new Producto("accesorio 3"));
            pedido.Borrar();
            pedido.Visualiza();

            Pedido pedido2 = new Pedido();
            pedido2.AgregaProducto(new Producto("vehiculo 11"));
            pedido2.AgregaProducto(new Producto("accesorio 21"));
            pedido2.Visualiza();
            pedido2.EstadoSiguiente();
            pedido2.Visualiza();
            pedido2.EstadoSiguiente();
            pedido2.Borrar();
            pedido2.Visualiza();
        }
    }
}
