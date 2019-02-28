using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    //Program is the subsriber class
    class Program
    {
        static void Main(string[] args)
        {
            //pass random value to the Counter Constructor
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            //waits until a key is pressed
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }
        //event handler ThesholdReached Writes to the console
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }
    //Adder is the publisher class
    class Counter
    {
        private int threshold;
        private int total;

        //threshold takes on value of random number
        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            // trigger the event when a's pressed is >= the threshold value
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }

        protected virtual void OnThresholdReached(EventArgs e)
        {
            //invoke the delagate
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler ThresholdReached;
    }
}
