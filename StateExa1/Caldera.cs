using System;
using System.Collections.Generic;
using System.Text;

namespace StateExa1
{
    class Caldera
    {

        // Variables de referencia a los estado
        private IEstado calentando;
        private IEstado alarma;
        private IEstado espera;

        // esta variable representa al estado actual
        private IEstado estado;

        private int temperatura;
        private int combustible;

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }

        internal IEstado Calentando { get => calentando; set => calentando = value; }
        internal IEstado Alarma { get => alarma; set => alarma = value; }
        internal IEstado Espera { get => espera; set => espera = value; }

        public Caldera()
        {
            temperatura = 20;
            combustible = 50;

            // Instanciamos los estados
            calentando = new EstadoCalentando(this);
            alarma = new EstadoAlarma(this);
            espera = new EstadoEspera(this);

            estado = calentando;
        }

        public void ColocarEstado(IEstado pEstado)
        {
            Console.WriteLine("--- Cambio de estado ---");
            estado = pEstado;
        }

        public void Trabajar()
        {
            estado.Trabajar();
        }

        public void CortarFuego()
        {
            estado.CortarFuego();
        }

        public void PonerCombustible()
        {
            estado.PonerCombustible();
        }
        public void ForzarFuego()
        {
            estado.ForzarFuego();
        }
        public override string ToString()
        {
            return estado.ToString();
        }
    }
}
