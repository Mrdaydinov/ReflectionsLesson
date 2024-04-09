using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsLesson
{
    internal class Person
    {
        public int Age { get; set; }
        public static int Increment { get; set; } = 0;

        public Person()
        {
            Age += ++Increment;
        }
    }
}
