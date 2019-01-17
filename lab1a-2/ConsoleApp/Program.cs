using System;

namespace ConsoleApp
{
    enum Location
    {
        World,
        Universe,
        Galaxy
    }
    class Program
    {

        static void Main(string[] args)
        {
            /* 
             * Each index in the locate array stores a different value so that the 
             * corresponding string value is returned when the getLocation function is called
             */
            Location[] locate = { Location.World, Location.Galaxy, Location.Universe };

            foreach(Location item in locate)
            {
                Console.WriteLine(String.Format("{0} {1}!",HelloWorld.hello,HelloWorld.getLocation(item)));
            }
            /* 
             * Output
             * Hello World!
             * Hello Galaxy!
             * Hello Universe!
             */
            Console.ReadKey();
        }

    }
}
