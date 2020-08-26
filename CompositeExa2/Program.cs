using System;

namespace CompositeExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************");
            Empresa empresa1 = new EmpresaSinFilial();
            empresa1.AgregaVehiculo();

            Empresa empresa2 = new EmpresaSinFilial();
            empresa2.AgregaVehiculo();
            empresa2.AgregaVehiculo();

            Empresa grupo = new EmpresaMadre();
            grupo.AgregaFilial(empresa1);
            grupo.AgregaFilial(empresa2);

            grupo.AgregaVehiculo();

            Console.WriteLine("Coste de mantenimiento total del grupo: {0}", grupo.CalculaCosteMantenimiento());
        }
    }
}
