using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal> { new Cow("Bill"), new Chicken("Jill"), new Cow("Phil"), new Chicken("Adam"), };
            //sorts the list using the compareTo method in the animal class
            animalList.Sort();
            foreach(var animal in animalList)
            {
                Console.WriteLine(animal.Name);
            }
            Console.ReadKey();
        }
    }
}
