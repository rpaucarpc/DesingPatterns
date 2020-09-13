using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa2
{
    public abstract class Control
    {
        public string Valor { get; protected set; }
        public Formulario Director { get; set; }
        public string Nombre{ get;protected set; }

        public Control(string nombre)
        {
            this.Valor = "";
            this.Nombre = nombre;
        }
        public abstract void Informa();

        protected void Modifica()
        {
            Director.ControlModificado(this);
        }
    }
}
