using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa2
{
    public abstract class Elemento
    {
        protected string descripcion;
        public Elemento(string pDescripcion)
        {
            descripcion = pDescripcion;
        }

        public bool PalabraClaveValida(string palabraClave)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }
    }
}
