using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExa1
{
    public interface IObservador
    {
        void Update(string mensaje);
        void UpdatePull();
    }
}
