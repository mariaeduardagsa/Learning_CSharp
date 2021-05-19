using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());
            //if(age >= 18)
            //{
            //    Console.WriteLine("You're good to go");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you aren't 18 yet");
            //}

            // Compound Expressions in If Statements


            // T && T = T -> And is only true when both sides are true
            // T && F = F
            // F && F = F
            // F && T = F


            // T || T = T
            // T || F = T
            // F || T = T
            // F || F = F -> Or is only false when both sides are false

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the moving rating?");
            char rating = char.Parse(Console.ReadLine());
            if (age <= 12 || age >= 65 && rating == 'G')
            {
                Console.WriteLine("Discount applies");
            }
            else
            {
                Console.WriteLine("NOT");
            }

        }
    }
}
