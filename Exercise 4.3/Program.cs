using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // hangman game
            string[] words = { "jump", "programming", "sky", "pictures", "river", "start", "grass", "google" };
            Random random = new Random();
            int randomIndex = random.Next(0, 8);
            string selectWord = words[randomIndex];

            string hiddenWord = "";

            for(int i = 0; i < selectWord.Length; i++)
            {
                hiddenWord += "*";
            }
            Console.WriteLine(hiddenWord);

            // Guessing stuff
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.Write("Guess a letter >> ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for(int i = 0; i < selectWord.Length; i++)
                {
                    if(selectWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;


                    }
                } if(containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! {0} is in the word", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry! {0} is not in the word", letter);
                } 
                Console.ResetColor();
            }
            // you won
            Console.WriteLine("Congratulations!! You win! The word was {0}", selectWord);

            
        }
    }
}
