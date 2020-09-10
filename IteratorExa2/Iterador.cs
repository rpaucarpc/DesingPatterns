using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa2
{
    public abstract class Iterador<TElemento> where TElemento : Elemento
    {
        public string palabraClaveConsulta { protected get; set; }
        protected int indice;
        public IList<TElemento> contenido { protected get; set; }

        public void Inicio()
        {
            indice = 0;
            int tamaño = contenido.Count;
            while ((indice < tamaño) && (!contenido[indice].PalabraClaveValida(palabraClaveConsulta)))
                indice++;
        }

        public void Siguiente()
        {
            int tamaño = contenido.Count;
            indice++;
            while ((indice < tamaño) && (!contenido[indice].PalabraClaveValida(palabraClaveConsulta)))
                indice++;
        }

        public TElemento Item()
        {
            if (indice < contenido.Count)
            {
                return contenido[indice];
            }
            else
                return null;
        }
    }
}
