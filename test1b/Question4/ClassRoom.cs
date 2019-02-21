using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class ClassRoom<S>
    {
        public List<S> students;
        public string GetClassList()
        {
            string ret = "";
            if (students is List<Student>)
            {
                foreach (var student in students)
                {
                    ret += "Name: " + (student as Student).name + "\nSaying: " + (student as Student).saying + "\n\n";
                }               
            }
            return ret;
        }
    }
}
