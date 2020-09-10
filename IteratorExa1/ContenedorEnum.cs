using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa1
{
    public class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            posicion = -1;
        }

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
    }
}
