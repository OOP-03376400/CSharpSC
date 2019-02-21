using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{

    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            c.evenNumberReached += c_ThresholdReached;

            Console.WriteLine("press 'e' key to increase total");

            while (Console.ReadKey(true).KeyChar == 'e')
            {
                Console.WriteLine("+ 1");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The even number of {0} was reached at {1}.", e.total, e.TimeReached);
            if (e.total == 10)
            {
                Console.ReadKey();
                Environment.Exit(0);
            }

        }
    }

    class Counter
    {
        private int threshold;
        private int total = 0;

        public void Add(int x)
        {
            total += 1;

            if (total % 2 == 0)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.total = total;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {

            EventHandler<ThresholdReachedEventArgs> handler = evenNumberReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> evenNumberReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int total { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
