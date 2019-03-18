using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Only The Premium Numbers");
            int checkNum = 2;
            int[] prime = new int[10];
            int index = 0;
            while(prime[9] == 0)
            {
                bool isPrime = true;
                int i;
                for (i = 2; i < checkNum; i++)
                {
                    if(checkNum % i == 0)
                        isPrime = false;
                }
                checkNum++;
                if(isPrime)
                {
                    prime[index] = i;
                    index++;
                }
            }
            foreach (var item in prime)
            {               
                Console.WriteLine(item + ",");
            }
            Console.ReadKey();
        }
    }
}
