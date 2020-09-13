using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExa2
{
    public class MementoImpl : IMemento
    {
        protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();

        public IList<OpcionVehiculo> estado
        {
            get
            {
                return opciones;
            }
            set
            {
                this.opciones.Clear();
                foreach (OpcionVehiculo opcion in value )
                {
                    this.opciones.Add(opcion);
                }
            }
        }
    }
}
