using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double payRate;
            do
            {
               
                Console.WriteLine("Please enter a valid payrate");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("The valid payrate that you entered is {0}", payRate);
        }
    }
}
