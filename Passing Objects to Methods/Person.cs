using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Objects_to_Methods
{
    class Person
    {
        private string name;
        private int age;

        public static int Count;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;


            Count++;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
