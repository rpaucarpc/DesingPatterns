using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace MementoExa1
{
    class Memento
    {
        internal void Salvar(Originador objeto)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(miStream, objeto);
            miStream.Close();

            Console.WriteLine("Se ha salvado");
        }

        internal Originador Restaurar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);
            Originador temp = (Originador)formateador.Deserialize(miStream);
            miStream.Close();

            Console.WriteLine("Se ha restaurado");

            return temp;
        }
    }
}
