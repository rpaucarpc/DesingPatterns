﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa2
{
    public class PedidoLuxemburgo : Pedido
    {
        protected override void CalculaIVA()
        {
            importeIVA = importeSinIVA * 0.15;
        }
    }
}
