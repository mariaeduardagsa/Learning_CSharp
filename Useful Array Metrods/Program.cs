using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useful_Array_Metrods
{
    class Program
    {
        static void Main(string[] args)
        {
            // binary search --------------------------------------------

            //int[] myArray = { 10, 15, 20, 30, 35, 40, 45}; // in order
            //Console.WriteLine("Enter number to check if it exists");
            //int number = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray, number);

            //if(answer < 0)
            //{
            //    Console.WriteLine("The number does not exist");

            //}
            //else
            //{
            //    Console.WriteLine("The numbers position in the array is {0}", answer);

            //}

            // sorting an array -----------------------------------------------

            //int[] myArray = { 10, 5, 7, 2, 55 };
            //Array.Sort(myArray);

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}


            // reverse array ---------------------------------------------------

            int[] myArray = { 10, 5, 7, 2, 55 };
            Array.Reverse(myArray);
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
