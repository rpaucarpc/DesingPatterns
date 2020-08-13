using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public class PedidoContado : Pedido
    {
        public PedidoContado( double pImporte):base(pImporte)
        {

        }
        public override void Paga()
        {
            Console.WriteLine("El pago del pedido por importe de: {0} se ha realizado", importe);
        }

        public override bool Valida()
        {
            return true;
        }
    }
}
