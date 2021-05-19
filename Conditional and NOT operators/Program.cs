using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_and_NOT_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // (condition)? true : false

            int x = 50;
            int y = 16;

            int biggestNumber = x > y ? x : y;
            Console.WriteLine(biggestNumber);

            double testScore = 95;
            Console.WriteLine((testScore >= 60) ? "Pass" : "Failed");

            int myInt = 5;
            if (!(myInt >= 6)) // negation operation 
            {
                Console.WriteLine("Less than 6");
            } else
            {
                Console.WriteLine("Biggest than 6");
            }

        }
    }
}
