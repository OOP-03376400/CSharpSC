using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1
{
    class Person
    {
        //make saying virtual so that derived classes can override the property
        public virtual string Saying { get { return "I'm Merely a Person"; } }
    }
}
