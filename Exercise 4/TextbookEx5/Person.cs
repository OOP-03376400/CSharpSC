using System;

namespace TextbookEx5
{
    public class Person : IComparable
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //CompareTo function is being used to get the difference between the age of two people
        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person otherPerson = obj as Person;

                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException(
                   "Object to compare to is not a Person object.");
            }
        }
    }
}
