using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa2
{
    public abstract class Pedido
    {
        protected double importeSinIVA;
        protected double importeIVA;
        protected double importeConIVA;

        protected abstract void CalculaIVA();

        public void CalculaPrecioConIVA()
        {
            this.CalculaIVA();
            importeConIVA = importeSinIVA + importeIVA;
        }

        public void SetImporteSinIVA(double importeSinIVA)
        {
            this.importeSinIVA = importeSinIVA;
        }

        public void Visualiza()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine("Importe sin IVA " + importeSinIVA);
            Console.WriteLine("Importe con IVA" + importeConIVA);
        }
    }
}
