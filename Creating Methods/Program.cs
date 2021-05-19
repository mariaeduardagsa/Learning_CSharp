using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            displayMessage();

            int answer = Add(5, 10);
            int secondAnswer = Add(answer, 5);
            Console.WriteLine(secondAnswer);
            
        }

        // METHODS ------------------------------------------
        public static void displayMessage()
        {
            Console.WriteLine("Hello, world");
        }
        public static int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }
    }
}
