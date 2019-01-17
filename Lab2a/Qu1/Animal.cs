using static System.Console;

namespace Qu1
{
    public abstract class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal() => name = "The animal with no name";

        public Animal(string newName) => name = newName;

        public void Feed() => WriteLine($"{name} has been fed.");
    }
}
