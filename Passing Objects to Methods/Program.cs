using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_Objects_to_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("Jesse", 20);
            //Console.WriteLine("BEFORE: {0}, {1}", p1.Name, p1.Age);
            //ChangePerson(p1);
            //Console.WriteLine("AFTER: {0}, {1}", p1.Name, p1.Age);


            //// another change
            //Person p2 = p1;
            //p2.Name = "TEST";
            //Console.WriteLine("AFTER Alter 2: {0}, {1}", p1.Name, p1.Age);

            // Arrays of Objects -----------------------------
            //int[] myArray = new int[2];
            //myArray[0] = 5;
            //myArray[1] = 10;

            //Person[] peopleArray = new Person[2];

            //peopleArray[0] = new Person("Bob", 5);
            //peopleArray[1] = new Person("Tess", 6);

            //for(int i = 0; i < peopleArray.Length; i++)
            //{
            //    Console.WriteLine("{0}, {1}", peopleArray[i].Name, peopleArray[i].Age);
            //}

            // static keyword ---------------------------------
            Person p1 = new Person("Ted", 5);
            Person p2 = new Person("Fred", 19);

            Console.WriteLine(Person.Count);

            Test();
        }

        //public static void ChangePerson(Person p1)
        //{
        //    p1.Name = "Jeff";
        //    p1.Age = 50;
        //}

        public static void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
