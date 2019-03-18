using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle<double> circleD = new Circle<double>(3.3);
            Circle<int> circleI = new Circle<int>(3);

            Console.WriteLine(String.Format("circleD {0}\ncircleI {1}", circleD.area(), circleI.area()));
            Console.ReadKey();
        }
    }
}
