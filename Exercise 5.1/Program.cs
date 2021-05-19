using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
        }
        public static void MultiplicationTable(int number)
        {
            for(int i = 2; i < 11; i++)
            {
                int answer = number * i;
                Console.WriteLine("{0,2} * {1,2} = {2,2}", i, number, answer);
            }
        }
    }
}
