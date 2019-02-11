using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    class PrintHelper
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;


        public void PrintNumber(int num)
        {
            
            if (beforePrintEvent != null)
                //send string "PrintNumber" to the beforePrintevent handler in number class
                beforePrintEvent.Invoke("PrintNumber");
            //write formatted number value
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            //send string "PrintMoney" to the beforePrintevent handler in number class
            if (beforePrintEvent != null)
                beforePrintEvent("PrintMoney");
            //write formatted money value
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemerature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }

        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
