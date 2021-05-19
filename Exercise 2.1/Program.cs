using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with hourly pay rate");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            if (hourlyPayRate < 7.5 || hourlyPayRate > 49.0)
            {
                Console.WriteLine("Invalid rate");
            }
            else
            {
                Console.WriteLine("The rate is valid");
            }
        }
    }
}
