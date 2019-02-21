using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Circle<T>
    {
        private T radius;
        

        public Circle(T r)
        {
            radius = r;
        }
        public object area()
        {
            object area = null;
            double d;
            object r = radius;
            
            if (typeof(T) == typeof(double))
            {
                area = Math.Pow((double)r, 2) * Math.PI;
            }
            else if (typeof(T) == typeof(int))
            {
                d = Math.Pow((int)r, 2) * Math.PI;
                area = (int)d;
            }
            return area;
        }
    }
}
