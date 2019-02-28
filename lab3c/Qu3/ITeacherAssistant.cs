using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    //the assistant must be a person or derived type
    interface ITeacherAssistant<P> where P : Person
    {
        P assistant { get; set; }
        int GetScore(P person);
    }
}
