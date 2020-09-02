using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ChainOfResponsabilityExa02
{
    public abstract class ObjetoBasico
    {
        public ObjetoBasico Siguiente { protected get; set; }

        private string DescripcionPorDefecto()
        {
            return "descripcion por defecto";
        }

        protected abstract string Descripcion { get; }

        public string DevuelveDescripcion()
        {
            string resultado;
            resultado = this.Descripcion;

            if (resultado != null)
                return resultado;
            if (Siguiente != null)
                return Siguiente.DevuelveDescripcion();
            else
                return this.DescripcionPorDefecto();
        }
    }
}
