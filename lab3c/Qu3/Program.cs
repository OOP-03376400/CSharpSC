using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create classroom and add person/school objects to populate the classroom
            ClassRoom<School, Person> classroom = new ClassRoom<School, Person>();
            ITStudent adam = new ITStudent()
            {
                Name = "Adam",
                score = 88,
            };
            NursingStudent don = new NursingStudent()
            {
                Name = "Don",
                score = 85,
            };
            Person graham = new Person()
            {
                Name = "Graham"
            };
            classroom.School = new School { Name = "Sault College" };
            classroom.People.Add("adam", adam);
            classroom.People.Add("don", don);

            //Classlist with Teacher
            Console.WriteLine(classroom.GetClassList(new Professor { Name = "Jeb", courseCode = "CSD311", assistant = adam }) + "\n\n");
            //Classlist with Professor
            Console.WriteLine(classroom.GetClassList(new Teacher { Name = "Billy", courseCode = "CSD311", assistant = graham }));
            Console.ReadKey();
        }
    }
}
