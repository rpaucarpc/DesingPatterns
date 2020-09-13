using System;
using System.Collections.Generic;
using System.Text;

namespace MementoExa1
{
    [Serializable]
    class Originador
    {
        public string Nombre{ get; set; }
        public int Modelo{ get; set; }
        public double Costo{ get; set; }
        public Originador(string pNombre, int pModelo, double pCosto)
        {
            Nombre = pNombre;
            Modelo = pModelo;
            Costo = pCosto;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} {1}, con costo de ${2}", Nombre, Modelo, Costo);
        }

        public Memento CreaMemento()
        {
            Memento miMemento = new Memento();
            miMemento.Salvar(this);
            return miMemento;
        }

        public void Restaura(Memento pMemento)
        {
            Originador temp = pMemento.Restaurar();
            Nombre = temp.Nombre;
            Modelo = temp.Modelo;
            Costo = temp.Costo;
        }
    }
}
