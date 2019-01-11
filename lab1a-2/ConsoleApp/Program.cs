using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HelloWorld
    {
        static public string hello
        {
            get
            {
                return "Hello";
            }
        }
        static public string world()
        {
            return "World";
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(HelloWorld.hello + " " + HelloWorld.world() + "!");
            Console.ReadKey();
        }

    }
}
