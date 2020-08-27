using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorExa02
{
    public abstract class Decorador : IComponenteGraficoVehiculo
    {
        protected IComponenteGraficoVehiculo componente;
        public Decorador(IComponenteGraficoVehiculo pComponente)
        {
            componente = pComponente;
        }

        public virtual void Visualiza()
        {
            componente.Visualiza();
        }
    }
}
