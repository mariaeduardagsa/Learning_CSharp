using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE --------------------------------------

            //int x = 0;
            //while(x < 5)
            //{
            //    Console.WriteLine("Hello");

            //    x++;
            //}

            // FOR -----------------------------------------

            //for (int i = 0; i < 10; i++ )
            //{
            //    Console.WriteLine("Hello");
            //}


            //Console.WriteLine("Enter an amount of times to print Hello");
            //int amount = int.Parse(Console.ReadLine());

            //for(int i = 0; i < amount; i++)
            //{
            //    Console.WriteLine("Hello");
            //}

            // WHILE LOOP -----------------------------------

            //Console.WriteLine("Hello");
            //string response = Console.ReadLine();
            //while (response == "again")
            //{
            //    Console.WriteLine("Hello");
            //    response = Console.ReadLine();
            //}

            // DO WHILE LOOP ----------------------------------

            string response;

            do
            {
                Console.WriteLine("Hello");
                response = Console.ReadLine();
            } while (response == "again");

        }
    }
}
