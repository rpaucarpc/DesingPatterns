using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa2
{
    public class Vehiculo : Sujeto
    {
        protected string _descripcion;
        protected double _precio;
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
                this.Notifica();
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
                this.Notifica();
            }
        }
    }
}
