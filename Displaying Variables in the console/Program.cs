using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Displaying_Variables_in_the_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello World";
            bool myBool = true;
            char myChar = 'A';


            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(myChar);

            // placeholder
            Console.WriteLine("The value of my Int is {0, 3} and the value of myDouble is {1, -3}", myInt, myDouble + ".");

            // Concatenation
            Console.WriteLine("The value of myInt is " + myInt + " and the value of myDouble is " + myDouble + ".");
        }
    }
}
