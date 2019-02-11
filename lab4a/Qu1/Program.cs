using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex1
{
    class Program
    {
        //declare a delegate that accepts a string
        delegate void printString(string s);
        static void WriteToScreen(string s)
        {
            Console.WriteLine(s);
        }
        static void WriteBackwards(string s)
        {
            //for loop iterates throught the string backwards and print each character
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
        static void Main(string[] args)
        {
            //create empty printString delegate
            printString ps;
            //Create delegates that include methods
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteBackwards);
            //add ps1 and ps2 to the empty delegate
            ps = ps1;
            ps += ps2;
            //execute the WriteToScreen and WriteBackwards Functions
            ps("Hello");
            //output should contain Hello olleH
            Console.ReadKey();
        }       
    }
}
