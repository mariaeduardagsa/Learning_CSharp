using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int number2 = int.Parse(Console.ReadLine());

            int add = number1 + number2;

            Console.WriteLine("The add of {0} and {1} is equal {2}", number1, number2, add);


        }
    }
}
