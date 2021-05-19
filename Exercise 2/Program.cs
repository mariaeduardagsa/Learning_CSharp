using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the length of the room");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the room");
            double width = double.Parse(Console.ReadLine());

            const double priceOfCarpeting = 20.99;

            double measureOfTheRoom = length * width;
            double totalPrice = measureOfTheRoom * priceOfCarpeting;
            
            Console.WriteLine("All money you need to carpet the {0} square meters room is ${1} ", measureOfTheRoom, totalPrice);
        }
    }
}
