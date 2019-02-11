using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex6
{
    class Program
    {
        static bool isPositiveInt(int i)
        {
            
            return i > 0;
        }
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40 };
            
            //send each item in list to the isPositiveInt function 
            bool res = intList.TrueForAll(isPositiveInt);
            //if all items in the list are greater than 0 res will be true
        }
    }
}
