using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu3
{
    //this interface forces teachers and professors to have a coursecode
    interface ICourseCode
    {
        string courseCode { get; set; }
    }
}
