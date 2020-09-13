using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExa2
{
    public class Formulario
    {
        protected IList<Control> controles = new List<Control>();
        protected IList<Control> controlesCoprestatario = new List<Control>();
        public PopupMenu menuCoprestatario { protected get; set; }
        public Boton botonOk { protected get; set; }
        protected bool enCurso = true;

        public void agregaControl(Control control)
        {
            controles.Add(control);
            control.Director = this;
        }

        public void AgregaControlCoprestatario(Control control)
        {
            controlesCoprestatario.Add(control);
            control.Director = this;
        }

        public void ControlModificado( Control control)
        {
            if (control == menuCoprestatario)
            {
                if (control.Valor == "con coprestatario")
                {
                    foreach (Control elementoCoprestatario in controlesCoprestatario)
                    {
                        elementoCoprestatario.Informa();
                    }
                }
            }
            if(control == botonOk)
            {
                enCurso = false;
            }
        }

        public void Informa()
        {
            while (true)
            {
                foreach (Control control in controles )
                {
                    control.Informa();
                    if (!enCurso)
                    {
                        return;
                    }
                }
            }
        }
    }
}
