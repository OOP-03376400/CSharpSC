using System;

namespace Qu1
{
    //Program is the subsriber class
    class Program
    {
        static void Main()
        {           
            Adder a = new Adder();
            //subsribe to the a_MultipleOfFiveReached event
            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
            //not a multiple of five so event is not triggered when add() is called
            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);

            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            Console.ReadKey();
        }

        //this function is called just after the MultipleOfFiveEventArgs constructor when OnMultipleOfFiveReached event is triggered
        static void a_MultipleOfFiveReached(object sender, MultipleOfFiveEventArgs e)
        {
            Console.WriteLine("Multiple of five reached: ", e.Total);
        }
    }
    //Adder is the publisher class
    public class Adder
    {
        //declare event handler
        public event EventHandler<MultipleOfFiveEventArgs> OnMultipleOfFiveReached;
        public int Add(int x, int y)
        {
            int iSum = x + y;
            //if isum is a multiple of 5 the event is triggered
            if ((iSum % 5 == 0) && (OnMultipleOfFiveReached != null))
            { OnMultipleOfFiveReached(this, new MultipleOfFiveEventArgs(iSum)); }
            return iSum;
        }
    }

    public class MultipleOfFiveEventArgs : EventArgs
    {
        //Total property takes on the the value of iSum when the constructor is called
        public MultipleOfFiveEventArgs(int iTotal)
        { Total = iTotal; }
        public int Total { get; set; }
    }
}
