using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Qu2
{
   public abstract class Animal : IComparable<Animal>
   {
      protected string name;

      public string Name
      {
         get { return name; }
         set { name = value; }
      }

      public Animal() => name = "The animal with no name";

      public Animal(string newName) => name = newName;

      public void Feed() => WriteLine($"{name} has been fed.");

      //method is implemented from the IComparable interface 
      //and is used to compare the animal names so they can be sorted alphabetically
      public int CompareTo(Animal other)
      {
            return this.name.CompareTo(other.name);           
      }
    }
}
