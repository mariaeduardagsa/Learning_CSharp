using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeric_Conversions
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }
        static void Main(string[] args)
        {
            int x = 5;
            double y = x;

            double myDouble = 5.5;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // declaring constants

            const int myConstInt = 5;

                    // myConstInt = 6; 

            Console.WriteLine(Math.PI);

            DayOfWeek today = DayOfWeek.FRIDAY;
            Console.WriteLine(today);

            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);

        }
    }
}
