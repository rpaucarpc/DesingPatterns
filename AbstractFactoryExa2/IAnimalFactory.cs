using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExa2
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
