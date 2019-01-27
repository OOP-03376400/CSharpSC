using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    class Program
    {
        static int Ternary(int? i)
        {
            return i == null ? 0 : (int)i; 
        }
        static int HasVal(int? i)
        {
            if (i.HasValue)
                return (int)i;  
            else
                return 0;
        }
        static int Coalescing(int? i)
        {
            return i ?? 0;
        }
        static void Main(string[] args)
        {
            //create null int's to send to the functions
            int? i = null;
            //send null int to each function
            int t = Ternary(i);
            int h = HasVal(i);
            int c = Coalescing(i);
            Console.WriteLine(
                String.Format("Ternary {0}\nHasValue {1}\nCoalescing {2}", t, h, c)
                );

            Console.ReadKey();
        }
    }
}
