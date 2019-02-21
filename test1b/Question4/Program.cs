using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom<Student> c = new ClassRoom<Student>();
            List<Student> s = new List<Student>();
            s.Add(new Student {name = "adam", saying = "student 1" });
            s.Add(new Student {name = "bill", saying = "student 2" });
            s.Add(new Student {name = "joe", saying = "student 3" });
            c.students = s;
            Console.WriteLine(c.GetClassList());
            Console.ReadKey();
        }
    }
}
