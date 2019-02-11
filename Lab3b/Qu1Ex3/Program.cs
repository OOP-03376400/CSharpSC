using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList1 = new List<int>();
            intList1.Add(10);
            intList1.Add(20);
            intList1.Add(30);
            intList1.Add(40);

            List<int> intList2 = new List<int>();
            //using AddRange allows a list to be added to another list
            intList2.AddRange(intList1);
        }
    }
}
