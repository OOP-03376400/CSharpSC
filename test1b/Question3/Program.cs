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
            //subscribe to the evenNumberReached event using event handler c_evenNumber
            c.evenNumberReached += c_evenNumber;

            Console.WriteLine("press 'e' key to increase total");

            //waits until e is pressed
            while (Console.ReadKey(true).KeyChar == 'e')
            {
                Console.WriteLine("+ 1");
                c.Add(1);
            }
        }

        static void c_evenNumber(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The even number of {0} was reached at {1}.", e.total, e.TimeReached);
            //stop at 10
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
            //add 1 to total every time e is pressed
            total += 1;

            //if total is even throw the event and send arguments, current time and value of total
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
                //invoke eventhandler delegate and send args to event handler
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> evenNumberReached;
    }

    //this class contains data for event arguments
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int total { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
