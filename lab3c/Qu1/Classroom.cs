using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu1
{
    class ClassRoom<S, P>
    {

        //Add storage for people and schools
        public Dictionary<string, P> People = new Dictionary<string, P>();

        public S School { get; set; }

        public string GetClassList()
        {
            //make sure school is School and person are Person
            if (!(School is School))
            {
                return "School is not valid";
            }

            //create a string containing school name, key and value from person dictionary
            string ret = "";

            foreach (var item in People)
            {
                if (item.Value is Person)
                    ret += item.Key + " says " + (item.Value as Person).Saying + "\n";
            }

            return (School as School).Name + " enrollment: " + ret;
        }

    }
}
