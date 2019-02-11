using System;
using System.Collections.Generic;
namespace Qu1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a collection of objects that are derived from animal absract class
            List<Animal> animalCollection = new List<Animal>();
            //call the constructors for cow and chicken using the name property from animal class
            animalCollection.Add(new Cow("Rual"));
            animalCollection.Add(new Chicken("Donna"));
            //call feed method from animal class for each animal in collection
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
            Console.ReadKey();
        }
    }
}
