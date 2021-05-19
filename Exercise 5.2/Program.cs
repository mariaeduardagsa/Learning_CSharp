using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int squared = Square(number);
            Console.WriteLine("{0} squared is {1}", number, squared);
            int cubed = Cube(number);
            Console.WriteLine("{0} cubed is {1}", number, cubed);

        }
        public static int Square(int number)
        {
            return number * number;
        }
        public static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}
