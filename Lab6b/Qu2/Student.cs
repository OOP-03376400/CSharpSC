using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qu2
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Student()
        {
            this.firstName = "Bill";
            this.lastName = "Phil";
            this.age = 55;
        }
    }
}
