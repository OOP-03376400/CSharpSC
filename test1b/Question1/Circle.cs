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
            //d is used so that radius can be converted to int before it is assigned to area
            double d;
            //unbox the radius
            object r = radius;
            
            //depending on the type of T, radius is calculated then unboxed using object area
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
