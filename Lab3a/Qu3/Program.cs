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
            int[] arr = new int[1];
            //?[] operator is saying if array is not null, add value of isNull to index 0
            int? isNull = arr?[0];
            Console.WriteLine(String.Format("nullInt = {0}\nnullDouble = {1}\nisNull = {2}",nullInt, nullDouble, isNull));
            Console.ReadKey();
        }
    }
}
