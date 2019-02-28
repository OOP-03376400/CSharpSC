using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a ClassRoom to store School and students
            ClassRoom<School, Person> classroom = new ClassRoom<School, Person>();
            //add school and students to classroom
            classroom.School = new School { Name = "CASS" };
            classroom.People.Add("Adam", new ITStudent());
            classroom.People.Add("Matt", new NursingStudent());
            Console.WriteLine(classroom.GetClassList());
            Console.ReadKey();
        }
    }
}
