using System;

namespace VisitorExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa1 = new EmpresaSinFilial("Empresa1", "info@empresa1.com", "Calle de la empresa 1");
            Empresa empresa2 = new EmpresaSinFilial("Empresa2", "info@empresa2.com", "Calle de la empresa 2");

            Empresa grupo1 = new EmpresaMadre("Grupo1", "info@grupo1", "calle del grupo 1");
            grupo1.AgregaFilial(empresa1);
            grupo1.AgregaFilial(empresa2);

            Empresa empresa3 = new EmpresaSinFilial("Empresa3", "info@empresa3.com", "Calle de la empresa 3");
            Empresa grupo2 = new EmpresaMadre("Grupo2", "info@grupo2", "calle del grupo 2");

            grupo2.AgregaFilial(grupo1);
            grupo2.AgregaFilial(empresa3);
            grupo2.AceptaVisitante(new VisitanteMailingComercial());
        }
    }
}
