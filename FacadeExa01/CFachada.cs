using Subsistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    public class CFachada
    {

        // Estos son los subsistemas que se estan utilizando
        private CSistemaCompra compra = new CSistemaCompra();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private cSubsistemaEnvio envio = new cSubsistemaEnvio();

        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }
    }
}
