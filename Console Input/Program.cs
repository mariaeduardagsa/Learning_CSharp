using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Hello, {0} {1}", name, lastName);

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            number += 10;
            Console.WriteLine("The new number is {0}", number);
        }
    }
}
