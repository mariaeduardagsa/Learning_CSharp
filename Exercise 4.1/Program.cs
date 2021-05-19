using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] zipCode = { "111" ,"222", "333", "444", "555", "666", "777", "888", "999", "1010" };

            Console.WriteLine("Enter your Zip Code");
            string checkZipCode = Console.ReadLine();

            bool contains = false;

            for (int i = 0; i < zipCode.Length; i++)
            {
                if(checkZipCode == zipCode[i])
                {
                    contains = true;
                    break;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("We do ship to this zip code");
            } else
            {
                Console.WriteLine("We dont ship in this zip code");
            }


        }
    }
}
