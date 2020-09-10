using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Xml.XPath;

namespace IteratorExa2
{
    public abstract class Catalogo<TElemento, TIterator>
        where TElemento : Elemento
        where TIterator: Iterador<TElemento>, new()
    {
        protected IList<TElemento> contenido = new List<TElemento>();

        public TIterator Busqueda(string palabraClaveConsulta)
        {
            TIterator resultado = new TIterator();
            resultado.palabraClaveConsulta = palabraClaveConsulta;
            resultado.contenido = contenido;
            return resultado;
        }
    }
}
