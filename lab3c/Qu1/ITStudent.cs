using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1
{
    class ITStudent : Person
    {
        //override Saying property from Person Class
        public override string Saying { get { return "We Like Computers"; } }
    }
}
