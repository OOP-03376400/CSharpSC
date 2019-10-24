using System;

namespace Qu2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create rectangles using int and double
            Rectangle<double> rectD = new Rectangle<double>(3, 4.3);
            Rectangle<int> rectI = new Rectangle<int>(3, 4);
            //print out the object values returned by area function
            Console.WriteLine(String.Format("rectD {0}\nrectI {1}",rectD.area(), rectI.area()));
            Console.ReadKey();
        }
    }
}
