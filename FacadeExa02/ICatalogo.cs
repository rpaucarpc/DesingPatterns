using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExa02
{
    public interface ICatalogo
    {
        IList<string> BuscaVehiculos(int precioMin, int precioMax);
    }
}
