using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa02
{
    public class MarcaDecorador : Decorador
    {
        public MarcaDecorador(IComponenteGraficoVehiculo pComponente) : base(pComponente)
        {
        }
        protected void VisualizaLogo()
        {
            Console.WriteLine("Logotipo de la marca");
        }

        public override void Visualiza()
        {
            base.Visualiza();
            this.VisualizaLogo();
        }
    }
}
