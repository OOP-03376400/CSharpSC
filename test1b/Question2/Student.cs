using System;
using System.Collections;

namespace Question2
{
    class Student : IComparable<Student>
    {
        public string name { get; set; }
        public string saying { get; set; }

        //sort students based on their name
        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }
    }
}
