using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 6);
            Add(5.5, 6.6);
            Add("Hello", "world");
            Console.WriteLine();
        }
        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add(string x, string y) // different data type
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
