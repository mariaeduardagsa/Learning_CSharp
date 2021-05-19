using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += i;

            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
