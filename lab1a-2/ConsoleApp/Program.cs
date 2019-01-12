using System;

namespace ConsoleApp
{
    enum Location
    {
        World,
        Universe,
        Galaxy
    }
    class HelloWorld
    {
        static public string hello
        {
            get
            {
                return "Hello";
            }
        }
        static public string getLocation(Location l)
        {
            switch (l)
            {
                case Location.World:
                    return "World";
                case Location.Universe:
                    return "Universe";
                case Location.Galaxy:
                    return "Galaxy";
                default:
                    return "Nobody";
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Location w = Location.World;
            Location g = Location.Galaxy;
            Location u = Location.Universe;
            Console.WriteLine(HelloWorld.hello + " " + HelloWorld.getLocation(w) + "!" +
                "\n" + HelloWorld.hello + " " + HelloWorld.getLocation(g) + "!" +
                "\n" + HelloWorld.hello + " " + HelloWorld.getLocation(u) + "!");
            Console.ReadKey();
        }

    }
}
