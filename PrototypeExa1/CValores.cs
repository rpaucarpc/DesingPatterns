using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeExa1
{
    public class CValores : IPrototipo
    {
        public int M { get; set; }
        public double Sumatoria{ get; set; }

        public CValores()
        {

        }

        public CValores(int pM)
        {
            M = pM;
            int n = 0;
            for (n = 0; n < 90; n++)
            {
                Sumatoria += Math.Sin(n * 0.0175);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", Sumatoria * M);
        }
        public object Clonar()
        {
            CValores clon = new CValores();
            clon.M = M;
            clon.Sumatoria = Sumatoria;
            return clon;
        }
    }
}
