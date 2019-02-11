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
            Number myNumber = new Number(100000);
            //call void methods from Number Class
            myNumber.PrintMoney();
            myNumber.PrintNumber();
            Console.ReadKey();
        }
    }
}
