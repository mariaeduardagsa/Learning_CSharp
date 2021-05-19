using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;

            //while(x < 5)
            //{
            //    Console.WriteLine("Hello");
            //    x++;
            //}

            // three components -> variable, condition and the alter statement

            int runningTotal = 0;
            Console.WriteLine("Enter a number, or -1 to quit");
            int number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                runningTotal += number;
                Console.WriteLine("Enter a number, or -1 to quit");
                number = int.Parse(Console.ReadLine());


            } // here this is break point
            Console.WriteLine("The total is {0}", runningTotal);


        }
    }
}
