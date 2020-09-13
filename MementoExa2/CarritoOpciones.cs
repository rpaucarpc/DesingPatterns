using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExa2
{
    public class CarritoOpciones
    {
        protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();

        public IMemento AgregaOpcion(OpcionVehiculo opcionVehiculo)
        {
            MementoImpl resultado = new MementoImpl();
            resultado.estado = opciones;

            IList<OpcionVehiculo> opcionesIncompatibles = opcionVehiculo.OpcionesIncompatibles;

            foreach (OpcionVehiculo opcion in opcionesIncompatibles)
                opciones.Remove(opcion);

            opciones.Add(opcionVehiculo);
            return resultado;
        }

        public void Anula( IMemento memento)
        {
            MementoImpl mementoImplInstance = memento as MementoImpl;

            if (mementoImplInstance == null)
            {
                return;
            }

            opciones = mementoImplInstance.estado;
        }

        public void Visualiza()
        {
            Console.WriteLine("Contenido del carrito de Opciones");
            foreach (OpcionVehiculo opcion in opciones )
            {
                opcion.Visualiza();
            }

            Console.WriteLine();
        }
    }
}
