using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    class ClassRoom<S, P>
    {

        //Add storage for people and schools
        public Dictionary<string, P> People = new Dictionary<string, P>();

        public S School { get; set; }

        public string GetClassList<T>(T teacher) where T : Teacher
        {
            //make sure school is School and person are Person
            if (!(School is School))
            {
                return "School is not valid";
            }
            string teacherString = teacher.Name + " is Teaching Course " + teacher.courseCode;

            //create a string containing school name, key and value from person dictionary
            string ret = "\n";

            foreach (var item in People)
            {
                if (item.Value is Person)
                    ret += item.Key + " says " + (item.Value as Person).Saying + "\n";
            }

            return (School as School).Name + " enrollment: \n\nTeacher:\n" + teacherString + "\n\nStudents:" + ret;
        }
    }
}
