﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExa1
{
    public class CAvion : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Empuja el acelerador");
        }

        public void Encender()
        {
            Console.WriteLine("Sigue todo el procedimiento");
        }

        public void Frenar()
        {
            Console.WriteLine("Jala el acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Mueve el timon de cola");
        }
    }
}
