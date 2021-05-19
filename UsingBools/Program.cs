using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingBools
{
    class Program
    {
        static void Main(string[] args)
        {
            // > >= <= == !=

            bool myBool = true;

            bool myBool2 = 5 > 6;
            Console.WriteLine(myBool2);

            myBool2 = 6 != 6;
            Console.WriteLine(myBool2);

            int hoursWorked = 41;
            bool doesEmployeerGetOverTime = hoursWorked > 40;
            Console.WriteLine("Does employee get overtime? {0}", doesEmployeerGetOverTime );

            //Console.ReadLine();

            // Using the Char Data Type

            char myChar = '\n';
            Console.WriteLine(myChar);

            // Using the String Data Type
            string myString = "Hello, World";
            Console.WriteLine(myString);

            String name1 = "Jesse";
            String name2 = "Jesse";
            int namesEqual = name1.CompareTo(name2);
            
            Console.WriteLine("Names equal {0}", namesEqual);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            // first position second how many character

            string firstCharacterOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharacterOfName);

            
            string middleSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = name1.StartsWith("Jess");
            Console.WriteLine(startsWith);
        }
    }
}
