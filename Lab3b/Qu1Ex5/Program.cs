using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            intList.Insert(1, 11);// inserts 11 at 1st index: after 10.
            Console.WriteLine("List 1\n");
            foreach (var el in intList)
                Console.Write(el + "\n");

            intList.Remove(10); // removes the 10 from a list

            intList.RemoveAt(2); //removes the 3rd element (index starts from 0)
            Console.WriteLine("\nList 2\n");
            foreach (var el in intList)
                Console.Write(el + "\n");
            Console.ReadKey();
        }
    }
}
