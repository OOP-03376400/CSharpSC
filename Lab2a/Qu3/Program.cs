using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    class Program
    {
        static void Main(string[] args)
        {
            //the int? operator is a shorter way of saying Nullable<int>
            int? nullInt = null;
            double? nullDouble = null;
            //?? operator states, if nullInt is null then set nullInt to -1 otherwise nullInt is unchanged
            nullInt = nullInt ?? -1;
            nullDouble = nullDouble ?? -3.1;
 
            Console.WriteLine(String.Format("nullInt = {0}\nnullDouble = {1}",nullInt, nullDouble));
            Console.ReadKey();
        }
    }
}
