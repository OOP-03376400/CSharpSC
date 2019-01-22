using System;

namespace Qu2
{
    public class Rectangle<T>
    {
        private T length;
        private T width;

        public Rectangle(T l, T w)
        {
            length = l;
            width = w;
        }
        public object area()
        {
            //using an object to store area allows a double or int value to be returned
            object area = null;
            //unbox length and width variables so they can be casted to double or int
            object l = length;
            object w = width;
            if(typeof(T) == typeof(double))
            {
                area = (double)l * (double)w;
            }
            else if (typeof(T) == typeof(int))
            {
                area = (int)l * (int)w;
            }
            return area;
        }
        
    }
}
