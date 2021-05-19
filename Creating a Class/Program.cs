using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tom", "Bob", 15, 75 ); // Constructor
            //s1.sayHello();
            //s1.SetName("");
            s1.Name = "";
            //  get and set methods -------------------------
            Console.WriteLine(s1.Name);
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.LastName);


            //Student s2 = new Student("Fred", 15, 90);
            //s2.sayHello();


            //Student s3 = new Student("Ted", 12, 70);
            //s3.sayHello();

            //Student s4 = new Student("Frank", 10);
            //s4.sayHello();
        }
    }
}
