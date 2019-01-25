using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //using the Ilist interface to instantiate list objects using different types
            IList<int> intList = new List<int>();
            //Add method is adding elements to the list
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());
        }
    }
}
