using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = new int[3];
            myArray1[0] = 5; // the first integer 
            myArray1[1] = 6;
            myArray1[2] = 7;

            // shorthand ----------------

            int[] myArray2 = new int[3] { 5, 6, 7 };
            int[] myArray3 = new int[] { 5, 6, 7 };
            int[] myArray4 = { 5, 6, 7 };


            // Using Loops with Array --------------------------

            int[] grades = { 55, 78, 86, 99, 100, 66 };

            //grades[0] += 3;
            //grades[1] += 3;
            //grades[2] += 3;
            //grades[3] += 3;
            //grades[4] += 3;

            for (int i = 0; i < grades.Length ; i++)
            {
                grades[i] += 3;
                Console.WriteLine(grades[i]);
            }

            // foreach sample ------------------------------------
            //foreach(int score in grades) // read only
            //{
            //    //score += 3; // cannot do this
            //    Console.WriteLine(score);
            //}

        }
    }
}
