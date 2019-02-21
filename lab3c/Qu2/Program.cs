using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom<School, Person> classroom = new ClassRoom<School, Person>();
            classroom.School = new School { Name = "Sault College" };
            classroom.People.Add("Adam", new ITStudent());
            classroom.People.Add("Don", new NursingStudent());
            Console.WriteLine(classroom.GetClassList(new Teacher { Name = "Jeb", courseCode = "CSD311" }));
            Console.ReadKey();
        }
    }
}
