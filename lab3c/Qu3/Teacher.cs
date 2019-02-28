using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    class Teacher : Person, ICourseCode, ITeacherAssistant<Person>
    {
        public override string Saying { get { return "I'm a Teacher"; } }
        public string courseCode { get; set; }
        public Person assistant { get; set; }
        public int GetScore(Person person)
        {
            return assistant.score;
        }
    }
}
