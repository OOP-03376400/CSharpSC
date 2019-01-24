using System;
using System.Collections;

namespace TextbookEx5
{
    public class PersonComparerName : IComparer
    {
        public static IComparer Default = new PersonComparerName();
        //Compare method makes sure both object are of type person 
        //then compares their name's string values
        public int Compare(object x, object y)
        {
            if (x is Person && y is Person)
            {
                return Comparer.Default.Compare(
                   ((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                throw new ArgumentException(
                   "One or both objects to compare are not Person objects.");
            }
        }
    }
}
