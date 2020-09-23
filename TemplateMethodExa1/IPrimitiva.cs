using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodExa1
{
    interface IPrimitiva
    {
        double Decorar(int cantidad);
        double Empacar(int cantidad);
    }
}
