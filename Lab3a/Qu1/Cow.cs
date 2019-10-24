using static System.Console;

namespace Qu1
{
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been milked.");
        //create cow objects and include a name for them
        public Cow(string newName) : base(newName) { }
    }
}