using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeExa2
{
    public abstract class FormularioMatriculacion
    {
        protected string contenido;
        protected IFormularioImpl implementacion;

        public FormularioMatriculacion(IFormularioImpl formularioImpl)
        {
            implementacion = formularioImpl;
        }

        public void Visualiza()
        {
            implementacion.DibujaTexto("Número de matricula existente: ");
        }

        public void GeneraDocumento()
        {
            implementacion.DibujaTexto("Solicitud de matriculación");
            implementacion.DibujaTexto("Número de matricula: " + contenido);
        }

        public bool AdministraZona()
        {
            contenido = implementacion.AdministraZonaIndicada();
            return this.ControlZona(contenido);
        }

        protected abstract bool ControlZona(string matricula);
    }
}
