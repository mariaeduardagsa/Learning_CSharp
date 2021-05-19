using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of your yard");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your yard");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double weeklyPrice;

            if (area < 400)
            {
                weeklyPrice = 25.0;
            }
            else if (area >= 400 && area < 600)
            {
                weeklyPrice = 35.0;

            }
            else
            {
                weeklyPrice = 50.0;
            }

            Console.WriteLine("The weekly feet is {0}", weeklyPrice);
            Console.WriteLine("The 20 week season price is {0}", weeklyPrice * 20);
        }
    }
}
