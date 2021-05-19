using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            Console.WriteLine("Guess the random number");
            int usersGuess = int.Parse(Console.ReadLine());

            //Console.WriteLine(randomNumber);

            Console.WriteLine("The random number was {0}", randomNumber);

            if(usersGuess < randomNumber)
            {
                Console.WriteLine("Your guess is too low");

            } else if(usersGuess > randomNumber)
            {
                Console.WriteLine("Your guess is too high");
            }
            else
            {
                Console.WriteLine("You are correct");
            }

        }
    }
}
