using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            //populate the list
            students.Add(new Student { name = "bill" });
            students.Add(new Student { name = "adam" });
            students.Add(new Student { name = "joe" });

            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student.name);
            }
            Console.ReadKey();
        }
    }
}
