using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorExa1
{
    public class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n * n;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }

}
