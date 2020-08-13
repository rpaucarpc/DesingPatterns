using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public class PedidoCredito : Pedido
    {
        public PedidoCredito( double pImporte):base(pImporte)
        {

        }
        public override void Paga()
        {
            Console.WriteLine("El pago del pedido a crédito por importe de: {0} se ha realizado", importe);
        }

        public override bool Valida()
        {
            return (importe >= 1000.0) && (importe <= 5000.0);
        }
    }
}
