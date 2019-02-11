using static System.Console;

namespace Qu1
{
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg.");
        //create chicken objects and include a name for them
        public Chicken(string newName) : base(newName) { }
    }
}
