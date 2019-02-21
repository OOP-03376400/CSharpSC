using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    class ClassRoom<S, P>
    {

        //Add storage for people and schools
        public Dictionary<string, P> People = new Dictionary<string, P>();

        public S School { get; set; }

        public string GetClassList<T>(T instructor)
        {
            string instructorSring;
            //make sure school is School and person are Person
            if (!(School is School))
            {
                return "School is not valid";
            }
            //if else gets info about the instructor that was passed in
            if (instructor is Teacher)
                instructorSring = (instructor as Teacher).Name + " is Teaching Course " + (instructor as Teacher).courseCode + " " 
                    + (instructor as Teacher).Saying + "\nwith assistant " + (instructor as Teacher).assistant.Name;

            else if (instructor is Professor)
                instructorSring = (instructor as Professor).Name + " is Teaching Course " + (instructor as Professor).courseCode + " " 
                    + (instructor as Professor).Saying + "\nwith assistant " + (instructor as Professor).assistant.Name;
            else
                return "Invalid Instructor";

            //create a string containing school name, key and value from person dictionary
            string ret = "\n";

            foreach (var item in People)
            {
                if (item.Value is Person)
                    ret += item.Key + " says " + (item.Value as Person).Saying + " Score: " + (item.Value as Person).score + "\n";
            }

            return (School as School).Name + " enrollment: \n\nTeacher:\n" + instructorSring + "\n\nStudents:" + ret;
        }
    }
}
