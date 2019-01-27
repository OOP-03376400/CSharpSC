using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };
            //for loops iterates through the list and prints the value of each int
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);
            Console.ReadKey();
        }
    }
}
