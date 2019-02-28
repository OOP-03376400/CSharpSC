using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    //same as teacher class except assistant must be an ITstudent
    class Professor : Person, ICourseCode, ITeacherAssistant<ITStudent>
    {
        public override string Saying { get { return "I'm a prof"; } }
        public string courseCode { get; set; }
        public ITStudent assistant { get; set; }

        public int GetScore(ITStudent person)
        {
            return assistant.score;
        }
    }
}
