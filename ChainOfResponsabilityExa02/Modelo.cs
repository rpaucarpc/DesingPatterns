using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsabilityExa02
{
    public class Modelo : ObjetoBasico
    {
        protected string laDescripcion;
        protected string nombre;

        public Modelo(string nombre, string descripcion)
        {
            this.laDescripcion = descripcion;
            this.nombre = nombre;
        }

        protected override string Descripcion
        {
            get
            {
                if (laDescripcion != null )
                {
                    return "Modelo " + nombre + " : " + laDescripcion;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
