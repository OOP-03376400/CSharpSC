using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            //this method of declaring a list initializes the objects in the list when the list is created
            
            IList<Student> studentList = new List<Student>() {
                new Student(){ StudentID=1, StudentName="Bill"},
                new Student(){ StudentID=2, StudentName="Steve"},
                new Student(){ StudentID=3, StudentName="Ram"},
                new Student(){ StudentID=1, StudentName="Moin"}
            };
        }
    }
}
