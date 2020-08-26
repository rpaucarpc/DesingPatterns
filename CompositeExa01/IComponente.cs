using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeExa01
{
    public interface IComponente<T>
    {
        T Nombre { get; set; }
        void Adicionar(IComponente<T> pElemento);
        IComponente<T> Borrar(T Elemento);
        IComponente<T> Buscar(T pElemento);
        string Mostrar(int pProfundidad);
    }
}
