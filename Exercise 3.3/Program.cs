using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);

            int usersGuess;
            int amountOfGuesses = 0;
            do
            {
                Console.WriteLine("Guess the random number");
                usersGuess = int.Parse(Console.ReadLine());
                   
                if(usersGuess < randomNumber)
                {
                    Console.WriteLine("You're guess was too low");
                } else if(usersGuess > randomNumber)
                {
                    Console.WriteLine("You're guess was too high");
                } else
                {
                    Console.WriteLine("You're guess is correct");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed {0} times", amountOfGuesses);
        }
    }
}
