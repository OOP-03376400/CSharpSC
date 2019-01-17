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
        public T area() => length * width;
    }
}
