using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa2
{
    public abstract class Pedido
    {
        protected double importe;
        public Pedido(double pImporte)
        {
            importe = pImporte;
        }

        public abstract bool Valida();
        public abstract void Paga();
    }
}
