using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the total amount of time in minutes only");
            int totalAmount = int.Parse(Console.ReadLine());

            int hours = totalAmount / 60;
            int minutes = totalAmount % 60;
            Console.WriteLine("The total amount of time was {0} hour and {1} minutes", hours, minutes);
        }
    }
}
