using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa02
{
    public class ModeloDecorador : Decorador
    {
        public ModeloDecorador(IComponenteGraficoVehiculo pComponente) : base(pComponente)
        {
        }


        protected void VisualizaInformacionTecnica()
        {
            Console.WriteLine("Información tecnica del modelo");
        }
        public override void Visualiza()
        {
            base.Visualiza();
            this.VisualizaInformacionTecnica();
            
        }
    }
}
