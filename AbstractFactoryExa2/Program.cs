using System;

namespace AbstractFactoryExa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* Pet animals ***************");

            IAnimalFactory animalFactory = new PetAnimalFactory();
            ITiger tiger1 = animalFactory.GetTiger();
            IDog dog1 = animalFactory.GetDog();

            tiger1.Action();
            tiger1.Speak();

            dog1.Action();
            dog1.Speak();

            Console.WriteLine("************* Wild animals ***************");

            animalFactory = new WildAnimalFactory();
            ITiger tiger2 = animalFactory.GetTiger();
            IDog dog2 = animalFactory.GetDog();

            tiger2.Action();
            tiger2.Speak();

            dog2.Action();
            dog2.Speak();

        }
    }
}
