using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsabilityExa02
{
    public class Vehiculo : ObjetoBasico
    {
        protected string laDescripcion;
        public Vehiculo( string descripcion)
        {
            laDescripcion = descripcion;
        }
        protected override string Descripcion
        {
            get
            {
                return laDescripcion;
            }
        }
    }
}
